using Tavstal.WynnNetSDK.Models.Items;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

/// <summary>
/// A request to quickly search for items by name from the Wynncraft API.
/// </summary>
public class ItemsQuickSearchRequest : HttpRequestBase<List<Item>>
{
    /// <summary>
    /// Creates a new request to quickly search for items by name.
    /// </summary>
    /// <param name="query">The search query to match item names.</param>
    public ItemsQuickSearchRequest(string query)
        : base(HttpMethod.Get, $"/v3/item/search/{query}")
    {
    }
}
