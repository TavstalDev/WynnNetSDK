using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Items;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class ItemsTests : TestBase
{
    public ItemsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Items/List.json",
        "Resources/Items/ListSets.json",
        "Resources/Items/QuickSearch.json",
        "Resources/Items/Search.json",
        "Resources/Items/GetMetadata.json",
        "Resources/Items/GetStaticMetadata.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - List Items from Database")]
    public async Task List()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ItemsListRequest(page: 1);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Total Results: " + result!.Controller.Count);
        foreach (var item in result.Results)
        {
            _testOutputHelper.WriteLine($"  {item.DisplayName} -> {item.Tier}");
            item.DisplayName.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - List Item Sets")]
    public async Task ListSets()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ItemsListSetsRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var sets = await request.GetResponseBodyAsync(response);
        sets.Should().NotBeNull();

        _testOutputHelper.WriteLine("Item Sets:");
        foreach (var set in sets!)
        {
            _testOutputHelper.WriteLine($"  {set.Value.InternalName} -> {set.Value.Parts.Count} parts");
            set.Value.InternalName.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 3 - 200 - Quick Search Items")]
    public async Task QuickSearch()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ItemsQuickSearchRequest("Idol");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var items = await request.GetResponseBodyAsync(response);
        items.Should().NotBeNull();

        _testOutputHelper.WriteLine("Quick Search Results:");
        foreach (var item in items!)
        {
            _testOutputHelper.WriteLine($"  {item.DisplayName} -> {item.Tier}");
            item.DisplayName.Should().Be("Idol");
        }
    }

    [Fact(DisplayName = "Sample 4 - 200 - Search Items with Body")]
    public async Task Search()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = resource.JsonRequest!.DeserializeJson<ItemSearchRequestBody>();
        body.Should().NotBeNull();

        var request = new ItemsSearchRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Search Results:");
        foreach (var item in result!.Results)
        {
            _testOutputHelper.WriteLine($"  {item.DisplayName} -> {item.Tier}");
            item.DisplayName.Should().Be("Idol");
        }
    }

    [Fact(DisplayName = "Sample 5 - 200 - Get Item Filter Metadata")]
    public async Task GetMetadata()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ItemsFilterMetadataRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Item Types:");
        foreach (var type in result!.Filters.Type)
            _testOutputHelper.WriteLine("  " + type);

        _testOutputHelper.WriteLine("Identifications:");
        foreach (var identification in result.Filters.Identifications)
            _testOutputHelper.WriteLine("  " + identification);
    }

    [Fact(DisplayName = "Sample 6 - 200 - Get Static Item Metadata")]
    public async Task GetStaticMetadata()
    {
        var resource = _resources[5];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ItemsFilterStaticMetadataRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Attack Speeds:");
        foreach (var attackSpeed in result!.AttackSpeed)
            _testOutputHelper.WriteLine($"  {attackSpeed.Key} -> {attackSpeed.Value}");

        _testOutputHelper.WriteLine("Item Types:");
        foreach (var type in result.Type)
            _testOutputHelper.WriteLine($"  {type.Key} -> {type.Value}");
    }
}
