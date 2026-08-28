namespace Tavstal.WynnNetSDK.Http.Requests.News;

public class NewsFetchRequest : HttpRequestBase
{
    public NewsFetchRequest(string type, string pk) 
        : base(HttpMethod.Get, $"/v3/publisher/articles/fetch/{type}/{pk}")
    {
    }
}