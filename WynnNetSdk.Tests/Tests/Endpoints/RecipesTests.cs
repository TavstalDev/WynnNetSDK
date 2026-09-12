using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Recipes;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class RecipesTests : TestBase
{
    public RecipesTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Recipes/List.json",
        "Resources/Recipes/Search.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - List Recipes")]
    public async Task List()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new RecipesListRequest(page: 1);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Recipes:");
        foreach (var recipe in result!.Results)
        {
            _testOutputHelper.WriteLine($"  {recipe.InternalName} -> {recipe.Type} ({recipe.Skill})");
            recipe.InternalName.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - Search Recipes with Body")]
    public async Task Search()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        resource.JsonRequest.Should().NotBeNullOrEmpty();
        var body = resource.JsonRequest!.DeserializeJson<RecipesSearchRequestBody>();
        body.Should().NotBeNull();

        var request = new RecipesSearchRequest(body!);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Search Results:");
        foreach (var recipe in result!.Results)
        {
            _testOutputHelper.WriteLine($"  {recipe.InternalName} -> {recipe.Type} ({recipe.Skill})");
            recipe.InternalName.Should().Be("Food1-3");
        }
    }
}
