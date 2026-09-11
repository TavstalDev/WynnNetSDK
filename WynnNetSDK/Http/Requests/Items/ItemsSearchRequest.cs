using System.Net.Http.Json;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Items.Responses;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

/// <summary>
/// A request to search for items from the Wynncraft API.
/// </summary>
public class ItemsSearchRequest : HttpRequestBase<ItemResult>
{
    /// <summary>
    /// Creates a new request to search for items.
    /// </summary>
    /// <param name="requestBody">The search criteria to filter items.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result without pagination.</param>
    public ItemsSearchRequest(ItemSearchRequestBody requestBody, int? page = null, bool? fullResult = null)
        : base(HttpMethod.Post, "/v3/item/search", requestBody)
    {
        List<string> queryParams = [];
        if (page is > 0)
            queryParams.Add($"page={page}");
        if (fullResult is true)
            queryParams.Add("fullResult");

        if (queryParams.Count == 0)
            return;

        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}
