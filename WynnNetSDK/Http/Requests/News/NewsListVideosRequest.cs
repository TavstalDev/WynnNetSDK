namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsListVideosRequest : HttpRequestBase<Dictionary<string, string>>
{
    public NewsListVideosRequest() 
        : base(HttpMethod.Get, "/v3/publisher/videos/list")
    {
    }
}