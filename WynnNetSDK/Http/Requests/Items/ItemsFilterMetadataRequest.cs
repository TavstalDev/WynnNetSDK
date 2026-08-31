using Tavstal.WynnNetSDK.Models.Items.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsFilterMetadataRequest : HttpRequestBase<ItemMetaResult>
{
    public ItemsFilterMetadataRequest() 
        : base(HttpMethod.Get, "/v3/item/metadata")
    { }
}