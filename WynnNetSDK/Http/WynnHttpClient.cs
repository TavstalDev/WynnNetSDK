using System.Net;
using System.Net.Http.Headers;
using Tavstal.WynnNetSDK.Http.Clients;

namespace Tavstal.WynnNetSDK.Http;

public sealed class WynnHttpClient : IWynnHttpClient, IDisposable
{
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private HttpClient _httpClient;
    private WynnEnvironment _environment;
    private WynnClientOptions _options;

    public AbilityClient Ability { get; private set; }
    public ClassesClient Classes { get; private set; }
    public GuildClient Guild { get; private set; }
    public ItemsClient Items { get; private set; }
    public LeaderboardClient Leaderboard { get; private set; }
    public MapClient Map { get; private set; }
    public NewsClient News { get; private set; }
    public PlayerClient Player { get; private set; }
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
        Search = null!;
    }
    
    public WynnHttpClient(WynnEnvironment environment, WynnClientOptions? options = null)
        : this(environment, new HttpClient(new SocketsHttpHandler
        {
            AutomaticDecompression = (options ?? new WynnClientOptions()).EnableCompression
                ? DecompressionMethods.GZip | DecompressionMethods.Deflate
                : DecompressionMethods.None,
            MaxConnectionsPerServer = (options ?? new WynnClientOptions()).MaxConnectionsPerServer,
            Proxy = (options ?? new WynnClientOptions()).Proxy
        }), options)
    { }
    
    internal WynnHttpClient(WynnEnvironment environment, HttpClient httpClient, WynnClientOptions? options = null)
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

        Ability = new AbilityClient(this);
        Classes = new ClassesClient(this);
        Guild = new GuildClient(this);
        Items = new ItemsClient(this);
        Leaderboard = new LeaderboardClient(this);
        Map = new MapClient(this);
        News = new  NewsClient(this);
        Player = new PlayerClient(this);
        Search = new SearchClient(this);
    }
    
    private void Initialize(WynnEnvironment environment, HttpClient httpClient, WynnClientOptions? options)
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
        
        Ability = new AbilityClient(this);
        Classes = new ClassesClient(this);
        Guild = new GuildClient(this);
        Items = new ItemsClient(this);
        Leaderboard = new LeaderboardClient(this);
        Map = new MapClient(this);
        News = new  NewsClient(this);
        Player = new PlayerClient(this);
        Search = new SearchClient(this);
    }
    
    //[FluentMethod(2, "Build")]
    public void Build()
    {
        // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
        var opts = _options ?? new WynnClientOptions();
        var client = new HttpClient(new SocketsHttpHandler
        {
            AutomaticDecompression = opts.EnableCompression
                ? DecompressionMethods.GZip | DecompressionMethods.Deflate
                : DecompressionMethods.None,
            MaxConnectionsPerServer = opts.MaxConnectionsPerServer,
            Proxy = opts.Proxy
        });
        Initialize(_environment, client, opts);
    }
    
    public void Dispose()
    {
        try
        {
            _semaphore.Dispose();
            _httpClient.Dispose(); 
        }catch { /* ignored */}
    }

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