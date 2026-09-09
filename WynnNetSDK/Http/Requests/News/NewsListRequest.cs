using Tavstal.WynnNetSDK.Models.News.Enums;
using Tavstal.WynnNetSDK.Models.News.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.News;

/// <summary>
/// A request to list articles of a specific type from the Wynncraft API.
/// </summary>
public class NewsListRequest : HttpRequestBase<ArticleResult>
{
    /// <summary>
    /// Creates a new request to list articles of a specific type.
    /// </summary>
    /// <param name="type">The type of articles to list.</param>
    /// <param name="page">The page number to retrieve.</param>
    public NewsListRequest(EArticleType type, int? page = null) 
        : base(HttpMethod.Get, $"/v3/publisher/articles/list/{type}")
    {
        List<string> queryParams = [];
        if (page is > 0)
            queryParams.Add($"page={page}");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}