using System.Net;
using System.Text;
using Tavstal.WynnNetSDK.Http;
using Tavstal.WynnNetSDK.Http.Requests.Items;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Http.Requests.Player;
using Tavstal.WynnNetSdk.Tests.Helpers;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class WynnHttpClientTests
{
    private static HttpResponseMessage Ok() => new(HttpStatusCode.OK)
    {
        Content = new StringContent("{}", Encoding.UTF8, "application/json")
    };

    private static HttpResponseMessage Status(HttpStatusCode statusCode) => new(statusCode)
    {
        Content = new StringContent("{}", Encoding.UTF8, "application/json")
    };

    [Fact(DisplayName = "200 - Injects the Bearer token when no header is set")]
    public async Task AddsBearerToken()
    {
        HttpRequestMessage? captured = null;
        var client = FakeHttpHelpers.CreateClient(request =>
        {
            captured = request;
            return Ok();
        });

        await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        captured.Should().NotBeNull();
        captured!.Headers.GetValues("Authorization").Should().Contain("Bearer test");
    }

    [Fact(DisplayName = "200 - Keeps a caller-provided Authorization header")]
    public async Task KeepsCustomAuthorization()
    {
        HttpRequestMessage? captured = null;
        var client = FakeHttpHelpers.CreateClient(request =>
        {
            captured = request;
            return Ok();
        });

        var request = new PlayerGetProfileRequest("Nepmia")
        {
            Headers =
            {
                ["Authorization"] = "Bearer custom"
            }
        };
        await client.SendAsync(request);

        captured!.Headers.GetValues("Authorization").Should().Contain("Bearer custom");
    }

    [Fact(DisplayName = "200 - Sends the default User-Agent")]
    public async Task SendsDefaultUserAgent()
    {
        HttpRequestMessage? captured = null;
        var client = FakeHttpHelpers.CreateClient(request =>
        {
            captured = request;
            return Ok();
        });

        await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        captured!.Headers.UserAgent.Should().Contain(u => u.Product != null && u.Product.Name == "Tavstal");
    }

    [Fact(DisplayName = "200 - Sends the custom User-Agent from the options")]
    public async Task SendsCustomUserAgent()
    {
        HttpRequestMessage? captured = null;
        var client = FakeHttpHelpers.CreateClient(request =>
        {
            captured = request;
            return Ok();
        }, new WynnClientOptions { ApplicationName = "MyApp" });

        await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        captured!.Headers.UserAgent.Should().Contain(u => u.Product != null && u.Product.Name == "MyApp");
    }

    [Fact(DisplayName = "429 - Retries 429 responses when RetryOnRateLimit is enabled")]
    public async Task RetriesOnRateLimit()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
                calls++ == 0 ? Status(HttpStatusCode.TooManyRequests) : Ok(),
            new WynnClientOptions { RetryDelay = TimeSpan.Zero });

        var response = await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        calls.Should().Be(2);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact(DisplayName = "429 - Does not retry 429 responses when RetryOnRateLimit is disabled")]
    public async Task DoesNotRetryOnRateLimit()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
            {
                calls++;
                return Status(HttpStatusCode.TooManyRequests);
            },
            new WynnClientOptions { RetryDelay = TimeSpan.Zero, RetryOnRateLimit = false });

        var response = await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        calls.Should().Be(1);
        response.StatusCode.Should().Be(HttpStatusCode.TooManyRequests);
    }

    [Fact(DisplayName = "500 - Retries server errors")]
    public async Task RetriesOnServerError()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
                calls++ == 0 ? Status(HttpStatusCode.InternalServerError) : Ok(),
            new WynnClientOptions { RetryDelay = TimeSpan.Zero });

        var response = await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        calls.Should().Be(2);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact(DisplayName = "500 - Stops after MaxRetries attempts")]
    public async Task StopsAfterMaxRetries()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
            {
                calls++;
                return Status(HttpStatusCode.InternalServerError);
            },
            new WynnClientOptions { RetryDelay = TimeSpan.Zero, MaxRetries = 3 });

        var response = await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        // The loop runs at most MaxRetries + 1 times, but the retry guard only allows
        // MaxRetries total attempts. See WynnHttpClient.SendAsync.
        calls.Should().Be(3);
        response.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
    }

    [Fact(DisplayName = "N/A - Retries on connection errors")]
    public async Task RetriesOnConnectionError()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
            {
                calls++;
                return calls == 1 ? throw new HttpRequestException("connection reset") : Ok();
            },
            new WynnClientOptions { RetryDelay = TimeSpan.Zero });

        var response = await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        calls.Should().Be(2);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact(DisplayName = "401 - Retries once on Unauthorized")]
    public async Task RetriesOnUnauthorized()
    {
        int calls = 0;
        var client = FakeHttpHelpers.CreateClient(_ =>
                calls++ == 0 ? Status(HttpStatusCode.Unauthorized) : Ok(),
            new WynnClientOptions { RetryDelay = TimeSpan.Zero });

        var response = await client.SendAsync(new PlayerGetProfileRequest("Nepmia"));

        calls.Should().Be(2);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    [Fact(DisplayName = "500 - Re-sends the request body on retry")]
    public async Task ReSendsBodyOnRetry()
    {
        var bodies = new List<string?>();
        var client = FakeHttpHelpers.CreateClient(request =>
            {
                bodies.Add(request.Content?.ReadAsStringAsync().GetAwaiter().GetResult());
                return bodies.Count == 1 ? Status(HttpStatusCode.InternalServerError) : Ok();
            },
            new WynnClientOptions { RetryDelay = TimeSpan.Zero });

        await client.SendAsync(new ItemsSearchRequest(new ItemSearchRequestBody { Query = "Ragni" }));

        bodies.Should().HaveCount(2);
        bodies[0].Should().Be(bodies[1]);
        bodies[0].Should().Contain("Ragni");
    }

    [Fact(DisplayName = "200 - Propagates cancellation")]
    public async Task PropagatesCancellation()
    {
        using var cts = new CancellationTokenSource();
        await cts.CancelAsync();
        var client = FakeHttpHelpers.CreateClient(_ => Ok());

        // ReSharper disable once AccessToDisposedClosure
        Func<Task> act = () => client.SendAsync(new PlayerGetProfileRequest("Nepmia"), cts.Token);

        await act.Should().ThrowAsync<OperationCanceledException>();
    }
}