using System.Net;
using System.Net.Http.Headers;
using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Clients;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// The main client for the Wynncraft API.
/// </summary>
public sealed class WynnHttpClient : IWynnHttpClient, IDisposable
{
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private HttpClient _httpClient;
    private WynnEnvironment _environment;
    private WynnClientOptions _options;

    /// <summary>Client for ability-related API endpoints.</summary>
    public AbilityClient Ability { get; private set; }
    /// <summary>Client for class-related API endpoints.</summary>
    public ClassesClient Classes { get; private set; }
    /// <summary>Client for guild-related API endpoints.</summary>
    public GuildClient Guild { get; private set; }
    /// <summary>Client for item-related API endpoints.</summary>
    public ItemsClient Items { get; private set; }
    /// <summary>Client for leaderboard-related API endpoints.</summary>
    public LeaderboardClient Leaderboard { get; private set; }
    /// <summary>Client for map-related API endpoints.</summary>
    public MapClient Map { get; private set; }
    /// <summary>Client for news-related API endpoints.</summary>
    public NewsClient News { get; private set; }
    /// <summary>Client for player-related API endpoints.</summary>
    public PlayerClient Player { get; private set; }
    /// <summary>Client for recipe-related API endpoints.</summary>
    public RecipesClient Recipes { get; private set; }
    /// <summary>Client for the search API endpoint.</summary>
    public SearchClient Search { get; private set; }

    // Used by the M31.FluentApi generated builder.
    // ReSharper disable once UnusedMember.Local
    private WynnHttpClient()
    {
        _httpClient = null!;
        _environment = null!;
        _options = null!;
        Ability = null!;
        Classes = null!;
        Guild = null!;
        Items = null!;
        Leaderboard = null!;
        Map = null!;
        News = null!;
        Player = null!;
        Recipes = null!;
        Search = null!;
    }

    /// <summary>
    /// Creates a new client with the given environment and optional settings.
    /// </summary>
    /// <param name="environment">The API environment with the base URL and token.</param>
    /// <param name="options">Optional client settings.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public WynnHttpClient(WynnEnvironment environment, WynnClientOptions? options = null, ICacheManager? cacheManager = null)
        : this(environment, new HttpClient(new SocketsHttpHandler
        {
            AutomaticDecompression = (options ?? new WynnClientOptions()).EnableCompression
                ? DecompressionMethods.GZip | DecompressionMethods.Deflate
                : DecompressionMethods.None,
            MaxConnectionsPerServer = (options ?? new WynnClientOptions()).MaxConnectionsPerServer,
            Proxy = (options ?? new WynnClientOptions()).Proxy
        }), cacheManager, options)
    { }

    internal WynnHttpClient(WynnEnvironment environment, HttpClient httpClient, ICacheManager? cacheManager = null, WynnClientOptions? options = null)
    {
        _httpClient = httpClient;
        _options = options ?? new WynnClientOptions();
        _environment = environment;
        _httpClient.MaxResponseContentBufferSize = _options.MaxResponseContentBufferSize;
        _httpClient.Timeout = _options.Timeout;

        // Ensure BaseAddress and some default headers exist when not already set on the supplied HttpClient.
        if (_httpClient.BaseAddress == null)
            _httpClient.BaseAddress = new Uri(_environment.BaseUrl);

        if (!_httpClient.DefaultRequestHeaders.Contains("Accept"))
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        if (_options.EnableCompression)
            _httpClient.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));

        if (!_httpClient.DefaultRequestHeaders.UserAgent.Any())
        {
            var agent = _options.ApplicationName != null ? UserAgent.GetUserAgentHeader(_options.ApplicationName) : UserAgent.GetUserAgentHeader();
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(agent);
        }

        Ability = new AbilityClient(this, cacheManager);
        Classes = new ClassesClient(this, cacheManager);
        Guild = new GuildClient(this, cacheManager);
        Items = new ItemsClient(this, cacheManager);
        Leaderboard = new LeaderboardClient(this, cacheManager);
        Map = new MapClient(this, cacheManager);
        News = new NewsClient(this, cacheManager);
        Player = new PlayerClient(this, cacheManager);
        Recipes = new RecipesClient(this, cacheManager);
        Search = new SearchClient(this, cacheManager);
    }

    /// <summary>
    /// Releases the resources used by this client.
    /// </summary>
    public void Dispose()
    {
        try
        {
            _semaphore.Dispose();
            _httpClient.Dispose();
        }
        catch { /* ignored */}
    }

    /// <summary>
    /// Sends an HTTP request to the Wynncraft API with automatic retry and authentication.
    /// </summary>
    /// <param name="request">The request to send.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The raw HTTP response message.</returns>
    public async Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default)
    {
        if (!request.Headers.ContainsKey("Authorization"))
        {
            if (!string.IsNullOrEmpty(_environment.Token))
                request.Headers["Authorization"] = $"Bearer {_environment.Token}";
        }

        byte[]? contentBuffer = null;
        if (request.Content != null)
            contentBuffer = await request.Content.ReadAsByteArrayAsync(cancellationToken);

        HttpResponseMessage response = null!;
        bool retriedOnAuth = false;
        // Add +1 because if the MaxRetries is 1 then only the base operation will run, and it won't retry.
        for (int i = 0; i < _options.MaxRetries + 1; i++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (contentBuffer != null && i > 0)
            {
                var newContent = new ByteArrayContent(contentBuffer);
                if (request.Content != null)
                    foreach (var header in request.Content.Headers)
                        newContent.Headers.TryAddWithoutValidation(header.Key, header.Value);
                request.Content = newContent;
            }

            try
            {
                response = await _httpClient.SendAsync(request.ToHttpRequestMessage(), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (HttpRequestException) when (i + 1 < _options.MaxRetries)
            {
                await Task.Delay(_options.RetryDelay, cancellationToken);
                continue;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized && !retriedOnAuth)
            {
                response.Dispose();
                retriedOnAuth = true;
                if (!string.IsNullOrEmpty(_environment.Token))
                    request.Headers["Authorization"] = $"Bearer {_environment.Token}";
                continue;
            }

            if (((response.StatusCode == HttpStatusCode.TooManyRequests && _options.RetryOnRateLimit) || (int)response.StatusCode >= 500)
                && i + 1 < _options.MaxRetries)
            {
                response.Dispose();
                await Task.Delay(_options.RetryDelay, cancellationToken);
                continue;
            }
            break;
        }
        return response;
    }
}
