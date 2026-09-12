using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Guild;
using Tavstal.WynnNetSDK.Models.Guild.Territory;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class SearchTests : TestBase
{
    public SearchTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Search/Search.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - Search")]
    public async Task Search()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new SearchRequest("Bo");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();


        _testOutputHelper.WriteLine($"Search -> {result!.Query}");
        _testOutputHelper.WriteLine("Players: ");
        foreach (var player in result.Players ?? new Dictionary<string, string>())
        {
            _testOutputHelper.WriteLine($"{player.Key} -> {player.Value}");
        }
        _testOutputHelper.WriteLine("Guilds: ");
        foreach (var guild in result.Guilds ?? new Dictionary<string, SearchGuildInfo>())
        {
            _testOutputHelper.WriteLine($"{guild.Key} -> {guild.Value.Name}");
        }
        _testOutputHelper.WriteLine("Items:");
        foreach (var item in result.Items ?? new List<Item>())
        {
            _testOutputHelper.WriteLine($"{item.DisplayName} -> {item.Type}");
        }
        _testOutputHelper.WriteLine("GuildsPrefix:");
        foreach (var guildsPrefix in result.GuildsPrefix ?? new Dictionary<string, GuildInfo>())
        {
            _testOutputHelper.WriteLine($"{guildsPrefix.Key} -> {guildsPrefix.Value.Name}");
        }
        _testOutputHelper.WriteLine("Territories:");
        foreach (var territory in result.Territories ?? new Dictionary<string, TerritoryLocation>())
        {
            _testOutputHelper.WriteLine($"{territory.Key} -> {territory.Value}");
        }
        _testOutputHelper.WriteLine("Discoveries:");
        foreach (var discoveries in result.Discoveries ?? new Dictionary<string, TerritoryLocation>())
        {
            _testOutputHelper.WriteLine($"{discoveries.Key} -> {discoveries.Value}");
        }
    }
}
