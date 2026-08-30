using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsFilterStaticMetadataRequest : HttpRequestBase<ItemMetaStaticResult>
{
    public ItemsFilterStaticMetadataRequest() 
        : base(HttpMethod.Get, "/v3/item/metadata?static")
    {

    }
}