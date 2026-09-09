using Tavstal.WynnNetSDK.Models.Search;

namespace Tavstal.WynnNetSDK.Http.Requests.Search;

/// <summary>
/// A request to search across the Wynncraft API.
/// </summary>
public class SearchRequest : HttpRequestBase<SearchResult>
{
    /// <summary>
    /// Creates a new request to search across the Wynncraft API.
    /// </summary>
    /// <param name="query">The search query to look for.</param>
    /// <param name="onlyOneResult">Whether to return only the top result.</param>
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