using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Map;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class MapTests : TestBase
{
    public MapTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Map/ListCamps.json",
        "Resources/Map/ListEvents.json",
        "Resources/Map/ListGatheringNodes.json",
        "Resources/Map/ListLootPools.json",
        "Resources/Map/ListMarkers.json",
        "Resources/Map/ListPlayerLocations.json",
        "Resources/Map/ListQuests.json",
        "Resources/Map/ListRaids.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - List Camps")]
    public async Task ListCamps()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListCampsRequest(level: 62);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var camps = await request.GetResponseBodyAsync(response);
        camps.Should().NotBeNull();

        _testOutputHelper.WriteLine("Camps:");
        foreach (var camp in camps!)
        {
            _testOutputHelper.WriteLine($"  {camp.Name} -> Level {camp.Level} ({camp.Type})");
            camp.Name.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - List World Events")]
    public async Task ListEvents()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListEventsRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var events = await request.GetResponseBodyAsync(response);
        events.Should().NotBeNull();

        _testOutputHelper.WriteLine("World Events:");
        foreach (var worldEvent in events!)
        {
            _testOutputHelper.WriteLine($"  {worldEvent.Name} -> Level {worldEvent.Level} ({worldEvent.Difficulty})");
            worldEvent.Name.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 3 - 200 - List Gathering Nodes")]
    public async Task ListGatheringNodes()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListGatheringNodesRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var nodes = await request.GetResponseBodyAsync(response);
        nodes.Should().NotBeNull();

        _testOutputHelper.WriteLine("Gathering Nodes:");
        foreach (var node in nodes!)
        {
            _testOutputHelper.WriteLine($"  {node.Resource} -> Level {node.Level} ({node.Type})");
            node.Resource.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 4 - 200 - List Loot Pools")]
    public async Task ListLootPools()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListLootPoolsRequest(level: 62);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var pools = await request.GetResponseBodyAsync(response);
        pools.Should().NotBeNull();

        _testOutputHelper.WriteLine("Loot Pools:");
        foreach (var pool in pools!)
        {
            _testOutputHelper.WriteLine($"  {pool.Name} -> {pool.Rewards.Count} rewards");
            pool.Name.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 5 - 200 - List Markers")]
    public async Task ListMarkers()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListMarkersRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var markers = await request.GetResponseBodyAsync(response);
        markers.Should().NotBeNull();

        _testOutputHelper.WriteLine("Markers:");
        foreach (var marker in markers!)
        {
            _testOutputHelper.WriteLine($"  {marker.Name} -> {marker.Icon} ({marker.X}, {marker.Y}, {marker.Z})");
            marker.Name.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 6 - 200 - List Player Locations")]
    public async Task ListPlayerLocations()
    {
        var resource = _resources[5];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListPlayerLocationsRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var players = await request.GetResponseBodyAsync(response);
        players.Should().NotBeNull();

        _testOutputHelper.WriteLine("Player Locations:");
        foreach (var player in players!)
        {
            _testOutputHelper.WriteLine($"  {player.Name} -> {player.Character} on {player.Server}");
            player.Name.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 7 - 200 - List Quests")]
    public async Task ListQuests()
    {
        var resource = _resources[6];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListQuestsRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var quests = await request.GetResponseBodyAsync(response);
        quests.Should().NotBeNull();

        _testOutputHelper.WriteLine("Total Quests: " + quests!.Quests);
        quests.Quests.Should().BeGreaterThan(0);
    }

    [Fact(DisplayName = "Sample 8 - 200 - List Raids")]
    public async Task ListRaids()
    {
        var resource = _resources[7];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new MapListRaidsRequest(level: 65);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var raids = await request.GetResponseBodyAsync(response);
        raids.Should().NotBeNull();

        _testOutputHelper.WriteLine("Raids:");
        foreach (var raid in raids!)
        {
            _testOutputHelper.WriteLine($"  {raid.Name} -> Level {raid.Level} ({raid.Type})");
            raid.Name.Should().NotBeNullOrEmpty();
        }
    }
}
