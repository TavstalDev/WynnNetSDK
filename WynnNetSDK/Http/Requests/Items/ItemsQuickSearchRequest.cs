namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsQuickSearchRequest : HttpRequestBase
{
    public ItemsQuickSearchRequest(string query) 
        : base(HttpMethod.Get, $"/v3/item/search/{query}")
    {
    }
}