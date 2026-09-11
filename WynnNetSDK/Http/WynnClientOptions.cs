using System.Net;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Options to configure the behaviour of <see cref="WynnHttpClient"/>.
/// </summary>
public class WynnClientOptions
{
    /// <summary>
    /// A custom name shown in the User-Agent header.
    /// </summary>
    public string? ApplicationName { get; set; }

    /// <summary>
    /// How long to wait for an HTTP response before the request is cancelled.
    /// </summary>
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(120);

    /// <summary>
    /// The maximum size in bytes of the response content buffer.
    /// </summary>
    public long MaxResponseContentBufferSize { get; set; } = 1024 * 1024 * 2;

    /// <summary>
    /// The maximum number of connections the client can open at the same time.
    /// </summary>
    public int MaxConnectionsPerServer { get; set; } = 10;

    /// <summary>
    /// How many times a failed request is retried before giving up.
    /// </summary>
    public int MaxRetries { get; set; } = 3;

    /// <summary>
    /// The time to wait between retries.
    /// </summary>
    public TimeSpan RetryDelay { get; set; } = TimeSpan.FromSeconds(1);

    /// <summary>
    /// When true, the client asks the server to compress responses with gzip or deflate.
    /// </summary>
    public bool EnableCompression { get; set; } = true;

    /// <summary>
    /// When true, the client automatically retries when the server returns HTTP 429 (Too Many Requests).
    /// </summary>
    public bool RetryOnRateLimit { get; set; } = true;

    /// <summary>
    /// An optional HTTP proxy used for all requests.
    /// </summary>
    public IWebProxy? Proxy { get; set; }
}
