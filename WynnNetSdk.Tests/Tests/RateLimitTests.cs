using System.Net;
using System.Reflection;
using System.Text;
using Tavstal.WynnNetSDK.Exceptions;
using Tavstal.WynnNetSDK.Http;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Player;
using Tavstal.WynnNetSdk.Tests.Helpers;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class RateLimitTests
{
    private const int DefaultRpm = 120;

    private static IWynnHttpClient CreateClient() => FakeHttpHelpers.CreateClient(_ => Ok());

    private static HttpResponseMessage Ok() => new(HttpStatusCode.OK)
    {
        Content = new StringContent("{}", Encoding.UTF8, "application/json")
    };

    [Fact(DisplayName = "200 - CanExecute is false after the default requests run out")]
    public async Task BecomesUnavailableAfterRequestsRunOut()
    {
        var player = CreateClient().Player;

        int executed = 0;
        while (player.CanExecute())
        {
            var result = await player.GetProfileAsync("Nepmia");
            result.IsSuccess.Should().BeTrue();
            executed++;
        }

        executed.Should().Be(DefaultRpm);
        player.CanExecute().Should().BeFalse();
    }

    [Fact(DisplayName = "200 - Throws RateLimitException when requests run out")]
    public async Task ThrowsWhenRequestsRunOut()
    {
        var player = CreateClient().Player;
        while (player.CanExecute())
            await player.GetProfileAsync("Nepmia");

        Func<Task<Result<PlayerDetailedInfo, ErrorResponse>>> act = () => player.GetProfileAsync("Nepmia");

        var exception = await act.Should().ThrowAsync<RateLimitException>();
        exception.And.AvailableAt.Should().BeAfter(DateTime.UtcNow);
    }

    [Fact(DisplayName = "200 - ResetRpm restores the ability to make requests")]
    public async Task ResetRestoresRequests()
    {
        var player = CreateClient().Player;
        while (player.CanExecute())
            await player.GetProfileAsync("Nepmia");

        player.ResetRpm();

        player.CanExecute().Should().BeTrue();
        var result = await player.GetProfileAsync("Nepmia");
        result.IsSuccess.Should().BeTrue();
    }

    [Fact(DisplayName = "200 - Automatically re-arms the counter when the rate-limit window passes")]
    public async Task AutoResetsAfterWindowPasses()
    {
        var player = CreateClient().Player;
        while (player.CanExecute())
            await player.GetProfileAsync("Nepmia");

        player.CanExecute().Should().BeFalse();

        // Simulate the rate-limit window having passed.
        var nextReset = typeof(HttpClientBase).GetField("_nextReset",
            BindingFlags.Instance | BindingFlags.NonPublic)!;
        nextReset.SetValue(player, DateTime.UtcNow.AddSeconds(-1));

        player.CanExecute().Should().BeTrue();

        var result = await player.GetProfileAsync("Nepmia");
        result.IsSuccess.Should().BeTrue();
    }
}