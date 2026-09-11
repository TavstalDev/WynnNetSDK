using Tavstal.WynnNetSDK.Models.Items.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

/// <summary>
/// A request to get static item filter metadata from the Wynncraft API.
/// </summary>
public class ItemsFilterStaticMetadataRequest : HttpRequestBase<ItemMetaStaticResult>
{
    /// <summary>
    /// Creates a new request to get static item filter metadata.
    /// </summary>
    public ItemsFilterStaticMetadataRequest()
        : base(HttpMethod.Get, "/v3/item/metadata?static")
    {

    }
}
