namespace Tavstal.WynnNetSDK.Http.Requests.Search;

public class SearchRequest : HttpRequestBase
{
    public SearchRequest(string query) 
        : base(HttpMethod.Get, $"/v3/search/{query}")
    {
    }
}