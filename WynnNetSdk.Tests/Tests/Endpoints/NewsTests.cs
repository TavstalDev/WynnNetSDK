using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.News;
using Tavstal.WynnNetSDK.Models.News.Enums;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class NewsTests : TestBase
{
    public NewsTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/News/List.json",
        "Resources/News/GetLegacy.json",
        "Resources/News/ListVideos.json",
        "Resources/News/Fetch.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - List News Articles")]
    public async Task News_List()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new NewsListRequest(EArticleType.ARTICLE);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var result = await request.GetResponseBodyAsync(response);
        result.Should().NotBeNull();

        _testOutputHelper.WriteLine("Articles:");
        foreach (var article in result!.Results)
        {
            _testOutputHelper.WriteLine($"  {article.Value.Title} -> {article.Value.Pk}");
            article.Value.Title.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 2 - 200 - Get Legacy News")]
    public async Task News_GetLegacy()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new NewsGetLegacyRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var articles = await request.GetResponseBodyAsync(response);
        articles.Should().NotBeNull();

        _testOutputHelper.WriteLine("Legacy News:");
        foreach (var article in articles!)
        {
            _testOutputHelper.WriteLine($"  {article.Title} by {article.Author}");
            article.Title.Should().NotBeNullOrEmpty();
        }
    }

    [Fact(DisplayName = "Sample 3 - 200 - List News Videos")]
    public async Task News_ListVideos()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new NewsListVideosRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var videos = await request.GetResponseBodyAsync(response);
        videos.Should().NotBeNull();

        _testOutputHelper.WriteLine("Videos:");
        foreach (var video in videos!)
            _testOutputHelper.WriteLine($"  {video.Value} -> https://www.youtube.com/watch?v={video.Key}");
    }

    [Fact(DisplayName = "Sample 4 - 200 - Fetch News Article")]
    public async Task News_Fetch()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new NewsFetchRequest(EArticleType.POLL, "104");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var article = await request.GetResponseBodyAsync(response);
        article.Should().NotBeNull();

        _testOutputHelper.WriteLine("Title: " + article!.Title);
        _testOutputHelper.WriteLine("Recap: " + article.Recap);
        _testOutputHelper.WriteLine("Created By: " + article.CreatedBy);
    }
}
