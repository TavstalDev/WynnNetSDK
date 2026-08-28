namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsListRequest : HttpRequestBase
{
    public NewsListRequest(string type) 
        : base(HttpMethod.Get, $"/v3/publisher/articles/list/{type}")
    {
    }
}