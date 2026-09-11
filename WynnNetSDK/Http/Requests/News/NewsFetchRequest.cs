using Tavstal.WynnNetSDK.Models.News;
using Tavstal.WynnNetSDK.Models.News.Enums;

namespace Tavstal.WynnNetSDK.Http.Requests.News;

/// <summary>
/// A request to fetch a specific article from the Wynncraft API.
/// </summary>
public class NewsFetchRequest : HttpRequestBase<Article>
{
    /// <summary>
    /// Creates a new request to fetch a specific article.
    /// </summary>
    /// <param name="type">The type of article to fetch.</param>
    /// <param name="pk">The primary key of the article.</param>
    public NewsFetchRequest(EArticleType type, string pk)
        : base(HttpMethod.Get, $"/v3/publisher/articles/fetch/{type}/{pk}")
    {
    }
}
