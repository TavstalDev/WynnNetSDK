using System.Net;

namespace Tavstal.WynnNetSDK.Http;

public class WynnClientOptions
{
    public string? ApplicationName { get; set; }
    
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(120);
    
    public long MaxResponseContentBufferSize { get; set; } = 1024 * 1024 * 2;
    
    public int MaxConnectionsPerServer { get; set; } = 10;
    
    public int MaxRetries { get; set; } = 3; 
    
    public TimeSpan RetryDelay { get; set; } = TimeSpan.FromSeconds(1);
    
    public bool EnableCompression { get; set; } = true;
    
    public bool RetryOnRateLimit { get; set; } = true;
    
    public IWebProxy? Proxy { get; set; }
}