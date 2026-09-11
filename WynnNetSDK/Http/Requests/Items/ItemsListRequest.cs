using Tavstal.WynnNetSDK.Models.Items.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

/// <summary>
/// A request to list all items from the Wynncraft API.
/// </summary>
public class ItemsListRequest : HttpRequestBase<ItemResult>
{
    /// <summary>
    /// Creates a new request to list all items.
    /// </summary>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result without pagination.</param>
    public ItemsListRequest(int? page = null, bool? fullResult = null)
        : base(HttpMethod.Get, "/v3/item/database")
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
