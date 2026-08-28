namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsGetLegacyRequest : HttpRequestBase
{
    public NewsGetLegacyRequest()
        : base(HttpMethod.Get, $"/v3/latest-news")
    {
        
    }
}