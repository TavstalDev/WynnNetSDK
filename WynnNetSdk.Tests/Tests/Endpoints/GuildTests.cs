using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Guild;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class GuildTests : TestBase
{
    public GuildTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Guild/GetByName.json",
        "Resources/Guild/List.json",
        "Resources/Guild/GetByUuid.json",
        "Resources/Guild/GetByPrefix.json",
        "Resources/Guild/ListSeasons.json",
        "Resources/Guild/ListTerritories.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - Get Guild by Name")]
    public async Task GetByName()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new GuildGetByNameRequest("Spectral");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guild = await request.GetResponseBodyAsync(response);
        guild.Should().NotBeNull();

        _testOutputHelper.WriteLine("Guild Name: " + guild!.Name);
        _testOutputHelper.WriteLine("Guild Prefix: " + guild.Prefix);
        _testOutputHelper.WriteLine("Guild Level: " + guild.Level);
        _testOutputHelper.WriteLine("Guild Territories: " + guild.Territories);
        guild.Members.Should().NotBeNull();
        _testOutputHelper.WriteLine("Guild Members: " + guild.Members.Total);
    }

    [Fact(DisplayName = "Sample 2 - 200 - List Guilds")]
    public async Task List()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new GuildListRequest(EIdentifier.NAME);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guilds = await request.GetResponseBodyAsync(response);
        guilds.Should().NotBeNull();

        _testOutputHelper.WriteLine("Guilds:");
        foreach (var guild in guilds!)
        {
            _testOutputHelper.WriteLine($"  {guild.Value.Uuid} -> {guild.Value.Prefix}");
            guild.Value.Prefix.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 3 - 200 - Get Guild by UUID")]
    public async Task GetByUuid()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new GuildGetByUuidRequest("adb5f0b5-5289-439c-9293-a29d220e7152");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guild = await request.GetResponseBodyAsync(response);
        guild.Should().NotBeNull();

        _testOutputHelper.WriteLine("Guild Name: " + guild!.Name);
        _testOutputHelper.WriteLine("Guild Prefix: " + guild.Prefix);
        guild.Uuid.Should().Be("adb5f0b5-5289-439c-9293-a29d220e7152");
    }

    [Fact(DisplayName = "Sample 4 - 200 - Get Guild by Prefix")]
    public async Task GetByPrefix()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new GuildGetPrefixRequest("SPC");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var guild = await request.GetResponseBodyAsync(response);
        guild.Should().NotBeNull();

        _testOutputHelper.WriteLine("Guild Name: " + guild!.Name);
        _testOutputHelper.WriteLine("Guild Prefix: " + guild.Prefix);
        guild.Prefix.Should().Be("SPC");
    }

    [Fact(DisplayName = "Sample 5 - 200 - List Guild Seasons")]
    public async Task ListSeasons()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new GuildListSeasonsRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var seasons = await request.GetResponseBodyAsync(response);
        seasons.Should().NotBeNull();

        _testOutputHelper.WriteLine("Guild Seasons:");
        foreach (var season in seasons!)
        {
            _testOutputHelper.WriteLine($"  Season {season.Key} -> {season.Value.RatingRewards.Count} rating rewards");
            season.Value.RatingRewards.Should().NotBeNull();
        }
    }

    [Fact(DisplayName = "Sample 6 - 200 - List Guild Territories")]
    public async Task ListTerritories()
    {
        var resource = _resources[5];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new GuildListTerritoriesRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var territories = await request.GetResponseBodyAsync(response);
        territories.Should().NotBeNull();

        _testOutputHelper.WriteLine("Guild Territories:");
        foreach (var territory in territories!)
        {
            _testOutputHelper.WriteLine($"  {territory.Key} -> {territory.Value.Guild.Prefix}");
            territory.Value.Guild.Prefix.Should().NotBeNullOrEmpty();
        }
    }
}
