using System.Net;
using System.Text;
using Tavstal.WynnNetSDK.Http;
using Tavstal.WynnNetSdk.Tests.Helpers;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class ErrorPathTests
{
    private static IWynnHttpClient CreateClient(Func<HttpRequestMessage, HttpResponseMessage> responder, WynnClientOptions? options = null)
        => FakeHttpHelpers.CreateClient(responder, options);

    private static HttpResponseMessage Json(HttpStatusCode statusCode, string body)
        => new(statusCode) { Content = new StringContent(body, Encoding.UTF8, "application/json") };

    [Fact(DisplayName = "404 - Parses an API error response into Result.Error")]
    public async Task ParsesApiError()
    {
        var client = CreateClient(_ => Json(HttpStatusCode.NotFound, """{"error":"Not Found","detail":"Player not found","code":404}"""));

        var result = await client.Player.GetProfileAsync("Nepmia");

        result.IsSuccess.Should().BeFalse();
        result.Error.Should().NotBeNull();
        result.Error!.Name.Should().Be("Not Found");
        result.Error.Message.Should().Be("Player not found");
        result.Error.Code.Should().Be(404);
    }

    [Fact(DisplayName = "502 - Returns a friendly failure for a non-JSON error body")]
    public async Task NonJsonErrorReturnsFriendlyFailure()
    {
        // A fresh response object per attempt: the retry loop disposes interim responses.
        var client = CreateClient(_ => new HttpResponseMessage(HttpStatusCode.BadGateway)
        {
            Content = new StringContent("oops", Encoding.UTF8, "text/plain")
        }, new WynnClientOptions { MaxRetries = 1 });

        var result = await client.Player.GetProfileAsync("Nepmia");

        result.IsError.Should().BeTrue();
        result.Error.Should().NotBeNull();
        result.Error!.Name.Should().Be("Serialization error.");
    }

    [Fact(DisplayName = "200 - Returns a failure for a malformed success body")]
    public async Task MalformedBodyReturnsFailure()
    {
        var client = CreateClient(_ => Json(HttpStatusCode.OK, "this is not json"));

        var result = await client.Player.GetProfileAsync("Nepmia");

        result.IsError.Should().BeTrue();
        result.Error.Should().NotBeNull();
        result.Error!.Name.Should().Be("Unexpected error occurred while deserializing success response body.");
    }
}