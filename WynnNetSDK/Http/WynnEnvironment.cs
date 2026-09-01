namespace Tavstal.WynnNetSDK.Http;

public class WynnEnvironment
{
    public string BaseUrl { get; }

    public string Token { get; }
    
    public WynnEnvironment(string token) : this("https://api.wynncraft.com", token) {}
    
    public WynnEnvironment(string baseUrl, string token)
    {
        if (string.IsNullOrEmpty(baseUrl))
            throw new ArgumentException("Base URL cannot be null or empty.", nameof(baseUrl));
        if (string.IsNullOrEmpty(token))
            throw new ArgumentException("Token cannot be null or empty.", nameof(token));
        
        BaseUrl = baseUrl;
        Token = token;
    }
}