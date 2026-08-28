namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsListVideosRequest : HttpRequestBase
{
    public NewsListVideosRequest() 
        : base(HttpMethod.Get, "/v3/publisher/videos/list")
    {
    }
}