using Tavstal.WynnNetSDK.Models.Items.Sets;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsListSetsRequest : HttpRequestBase<Dictionary<string, ItemSet>>
{
    public ItemsListSetsRequest() 
        : base(HttpMethod.Get, "/v3/item/sets")
    {
    }
}