using Tavstal.WynnNetSDK.Models.Items.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

/// <summary>
/// A request to get item filter metadata from the Wynncraft API.
/// </summary>
public class ItemsFilterMetadataRequest : HttpRequestBase<ItemMetaResult>
{
    /// <summary>
    /// Creates a new request to get item filter metadata.
    /// </summary>
    public ItemsFilterMetadataRequest() 
        : base(HttpMethod.Get, "/v3/item/metadata")
    { }
}