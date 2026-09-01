using Tavstal.WynnNetSdk.Tests.Helpers;
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
    public async Task Search_Search()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        // TODO
    }
}
