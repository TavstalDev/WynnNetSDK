namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsListSetsRequest : HttpRequestBase
{
    public ItemsListSetsRequest() 
        : base(HttpMethod.Get, "/v3/item/sets")
    {
    }
}