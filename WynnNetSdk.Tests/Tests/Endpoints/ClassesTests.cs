using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Classes;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class ClassesTests : TestBase
{
    public ClassesTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Classes/List.json",
        "Resources/Classes/Get.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - List All Classes")]
    public async Task List()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ClassesListRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var classes = await request.GetResponseBodyAsync(response);
        classes.Should().NotBeNull();

        _testOutputHelper.WriteLine("Classes:");
        foreach (var entry in classes!)
        {
            _testOutputHelper.WriteLine($"  {entry.Value.Name} -> Difficulty {entry.Value.OverallDifficultx}");
            entry.Value.Name.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - Get Class by Type")]
    public async Task Get()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new ClassesGetRequest(EClass.ARCHER);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var detail = await request.GetResponseBodyAsync(response);
        detail.Should().NotBeNull();

        _testOutputHelper.WriteLine("Class: " + detail!.Name);
        _testOutputHelper.WriteLine("Lore: " + detail.Lore);
        _testOutputHelper.WriteLine("Archetypes:");
        foreach (var archetype in detail.Archtypes)
            _testOutputHelper.WriteLine($"  {archetype.Value.Name} -> Difficulty {archetype.Value.Difficulty}");
    }
}
