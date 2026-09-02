using Tavstal.WynnNetSDK.Models.Search;

namespace Tavstal.WynnNetSDK.Http.Requests.Search;

public class SearchRequest : HttpRequestBase<SearchResult>
{
    public SearchRequest(string query, bool onlyOneResult = false) 
        : base(HttpMethod.Get, $"/v3/search/{query}")
    {
        List<string> queryParams = [];
        if (onlyOneResult)
            queryParams.Add($"only");

        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}