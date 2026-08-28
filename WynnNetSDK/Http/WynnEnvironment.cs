using System.Text;

namespace Tavstal.WynnNetSDK.Http;

public class WynnEnvironment
{
    public string BaseUrl { get; }

    public string Token { get; }
    
    public string WebUrl { get; }
    
    protected WynnEnvironment(string baseUrl, string token, string webUrl)
    {
        if (string.IsNullOrEmpty(baseUrl))
            throw new ArgumentException("Base URL cannot be null or empty.", nameof(baseUrl));
        if (string.IsNullOrEmpty(token))
            throw new ArgumentException("Token cannot be null or empty.", nameof(token));
        if (string.IsNullOrEmpty(webUrl))
            throw new ArgumentException("Web URL cannot be null or empty.", nameof(webUrl));
        
        BaseUrl = baseUrl;
        Token = token;
        WebUrl = webUrl;
    }
}