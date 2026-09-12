namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Holds the API base URL and token used to connect to the Wynncraft API.
/// </summary>
public class WynnEnvironment
{
    /// <summary>
    /// The base URL of the Wynncraft API.
    /// </summary>
    public string BaseUrl { get; }

    /// <summary>
    /// The API token used for authentication.
    /// </summary>
    public string Token { get; }

    /// <summary>
    /// Creates a new environment with the default base URL and the given token.
    /// </summary>
    /// <param name="token">The API token to use.</param>
    public WynnEnvironment(string token) : this("https://api.wynncraft.com", token) { }

    /// <summary>
    /// Creates a new environment with a custom base URL and token.
    /// </summary>
    /// <param name="baseUrl">The base URL of the API.</param>
    /// <param name="token">The API token to use.</param>
    public WynnEnvironment(string baseUrl, string token)
    {
        if (string.IsNullOrWhiteSpace(baseUrl))
            throw new ArgumentException("Base URL cannot be null or empty.", nameof(baseUrl));
        if (string.IsNullOrWhiteSpace(token))
            throw new ArgumentException("Token cannot be null or empty.", nameof(token));

        BaseUrl = baseUrl;
        Token = token;
    }
}
