using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Leaderboard;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class LeaderboardTests : TestBase
{
    public LeaderboardTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Leaderboard/ListTypes.json",
        "Resources/Leaderboard/Get.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - List Leaderboard Types")]
    public async Task ListTypes()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new LeaderboardListRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var types = await request.GetResponseBodyAsync(response);
        types.Should().NotBeNull();

        _testOutputHelper.WriteLine("Leaderboard Types:");
        foreach (var type in types!)
        {
            _testOutputHelper.WriteLine("  " + type);
            type.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - Get Leaderboard")]
    public async Task Get()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new LeaderboardGetRequest("lb_type");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var entries = await request.GetResponseBodyAsync(response);
        entries.Should().NotBeNull();

        _testOutputHelper.WriteLine("Leaderboard Entries:");
        foreach (var entry in entries!)
        {
            _testOutputHelper.WriteLine($"  {entry.Key}: {entry.Value.Name} -> {entry.Value.Uuid}");
            entry.Value.Name.Should().NotBeNullOrEmpty();
        }
    }
}
