using Tavstal.WynnNetSDK.Models.Items.Sets;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

/// <summary>
/// A request to list all item sets from the Wynncraft API.
/// </summary>
public class ItemsListSetsRequest : HttpRequestBase<Dictionary<string, ItemSet>>
{
    /// <summary>
    /// Creates a new request to list all item sets.
    /// </summary>
    public ItemsListSetsRequest() 
        : base(HttpMethod.Get, "/v3/item/sets")
    {
    }
}