using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Abilities;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class AbilityTests : TestBase
{
    public AbilityTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Ability/GetClassTree.json",
        "Resources/Ability/GetClassTreeMap.json",
        "Resources/Ability/GetClassAspects.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - Get Class Ability Tree")]
    public async Task Ability_GetClassTree()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new AbilityGetClassTreeRequest(EClass.ARCHER);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var tree = await request.GetResponseBodyAsync(response);
        tree.Should().NotBeNull();

        _testOutputHelper.WriteLine("Archetypes:");
        foreach (var archetype in tree!.Archtypes)
            _testOutputHelper.WriteLine($"  {archetype.Value.Name} -> {archetype.Value.Description}");

        _testOutputHelper.WriteLine("Pages:");
        foreach (var page in tree.Pages)
        {
            foreach (var ability in page.Value)
                _testOutputHelper.WriteLine($"  Page {page.Key}: {ability.Value.Name} -> {ability.Value.Description[0]}");
            page.Value.Should().NotBeEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - Get Class Ability Tree Map")]
    public async Task Ability_GetClassTreeMap()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new AbilityGetClassTreeMapRequest(EClass.ARCHER);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var map = await request.GetResponseBodyAsync(response);
        map.Should().NotBeNull();

        _testOutputHelper.WriteLine("Ability Map:");
        foreach (var entry in map!)
        {
            _testOutputHelper.WriteLine($"  {entry.Key}:");
            foreach (var node in entry.Value)
                _testOutputHelper.WriteLine($"    {node.Type} @ ({node.Coordinates.X}, {node.Coordinates.Y})");
            entry.Value.Should().NotBeEmpty();
        }
    }

    [Fact(DisplayName = "Sample 3 - 200 - Get Class Aspects")]
    public async Task Ability_GetClassAspects()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new AbilityGetClassAspectsRequest(EClass.ARCHER);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var aspects = await request.GetResponseBodyAsync(response);
        aspects.Should().NotBeNull();

        _testOutputHelper.WriteLine("Aspects:");
        foreach (var aspect in aspects!)
        {
            _testOutputHelper.WriteLine($"  {aspect.Name} -> {aspect.Rarity} ({aspect.RequiredClass})");
            aspect.Name.Should().NotBeNullOrEmpty();
        }
    }
}
