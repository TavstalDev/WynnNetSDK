using Tavstal.WynnNetSDK.Models.Items;

namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsQuickSearchRequest : HttpRequestBase<List<Item>>
{
    public ItemsQuickSearchRequest(string query) 
        : base(HttpMethod.Get, $"/v3/item/search/{query}")
    {
    }
}