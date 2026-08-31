using Tavstal.WynnNetSDK.Models.News;

namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsGetLegacyRequest : HttpRequestBase<List<LegacyArticle>>
{
    public NewsGetLegacyRequest()
        : base(HttpMethod.Get, $"/v3/latest-news")
    {
        
    }
}