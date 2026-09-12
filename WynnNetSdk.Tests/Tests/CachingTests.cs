using System.Net;
using System.Text;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Mocks;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class CachingTests
{
    private const string ProfileKey = "GET:/v3/player/Nepmia";

    private static HttpResponseMessage Ok() => new(HttpStatusCode.OK)
    {
        Content = new StringContent("{}", Encoding.UTF8, "application/json")
    };

    [Fact(DisplayName = "200 - Reuses a cached response without another HTTP call")]
    public async Task ReusesResponseWithoutHttpCall()
    {
        int calls = 0;
        var cache = new InMemoryCacheManager();
        var client = FakeHttpHelpers.CreateClient(_ =>
        {
            calls++;
            return Ok();
        }, cacheManager: cache);

        var first = await client.Player.GetProfileAsync("Nepmia");
        var second = await client.Player.GetProfileAsync("Nepmia");

        first.IsSuccess.Should().BeTrue();
        second.IsSuccess.Should().BeTrue();
        calls.Should().Be(1);
        cache.AddCalls.Should().Be(1);
    }

    [Fact(DisplayName = "200 - Fetches again when a cache entry expires")]
    public async Task FetchesAgainWhenEntryExpires()
    {
        int calls = 0;
        var cache = new InMemoryCacheManager();
        var client = FakeHttpHelpers.CreateClient(_ =>
        {
            calls++;
            return Ok();
        }, cacheManager: cache);

        await client.Player.GetProfileAsync("Nepmia");
        cache.ExpireAll();
        await client.Player.GetProfileAsync("Nepmia");

        calls.Should().Be(2);
    }

    [Fact(DisplayName = "200 - Caches different requests separately")]
    public async Task SeparatesRequestsByKey()
    {
        int calls = 0;
        var cache = new InMemoryCacheManager();
        var client = FakeHttpHelpers.CreateClient(_ =>
        {
            calls++;
            return Ok();
        }, cacheManager: cache);

        await client.Player.GetProfileAsync("A");
        await client.Player.GetProfileAsync("B");
        await client.Player.GetProfileAsync("A");
        await client.Player.GetProfileAsync("B");

        calls.Should().Be(2);
        cache.AddCalls.Should().Be(2);
    }

    [Fact(DisplayName = "200 - Makes an HTTP call every time without a cache manager")]
    public async Task HitsHttpWithoutManager()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
        {
            calls++;
            return Ok();
        });

        await client.Player.GetProfileAsync("Nepmia");
        await client.Player.GetProfileAsync("Nepmia");

        calls.Should().Be(2);
    }

    [Fact(DisplayName = "200 - Stores the endpoint's cache duration")]
    public async Task StoresEndpointDuration()
    {
        var cache = new InMemoryCacheManager();
        var client = FakeHttpHelpers.CreateClient(_ => Ok(), cacheManager: cache);

        var before = DateTime.UtcNow;
        await client.Player.GetProfileAsync("Nepmia");
        var after = DateTime.UtcNow;

        var stored = cache.GetStored(ProfileKey);
        stored.Should().NotBeNull();
        stored!.Value.ValidUntilUtc.Should().BeOnOrAfter(before.AddSeconds(119))
            .And.BeOnOrBefore(after.AddSeconds(121));
    }
}