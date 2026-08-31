using Tavstal.WynnNetSDK.Models.News;

namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsFetchRequest : HttpRequestBase<Article>
{
    public NewsFetchRequest(EArticleType type, string pk) 
        : base(HttpMethod.Get, $"/v3/publisher/articles/fetch/{type}/{pk}")
    {
    }
}