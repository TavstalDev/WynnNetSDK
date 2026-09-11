namespace Tavstal.WynnNetSDK.Http.Requests.News;

/// <summary>
/// A request to list all publisher videos from the Wynncraft API.
/// </summary>
public class NewsListVideosRequest : HttpRequestBase<Dictionary<string, string>>
{
    /// <summary>
    /// Creates a new request to list all publisher videos.
    /// </summary>
    public NewsListVideosRequest()
        : base(HttpMethod.Get, "/v3/publisher/videos/list")
    {
    }
}
