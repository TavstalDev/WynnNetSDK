using Tavstal.WynnNetSDK.Models.News;

namespace Tavstal.WynnNetSDK.Http.Requests.News;

/// <summary>
/// A request to get the latest legacy news from the Wynncraft API.
/// </summary>
public class NewsGetLegacyRequest : HttpRequestBase<List<LegacyArticle>>
{
    /// <summary>
    /// Creates a new request to get the latest legacy news.
    /// </summary>
    public NewsGetLegacyRequest()
        : base(HttpMethod.Get, $"/v3/latest-news")
    {

    }
}
