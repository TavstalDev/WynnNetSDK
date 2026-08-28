namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsListRequest : HttpRequestBase
{
    public ItemsListRequest() 
        : base(HttpMethod.Get, "/v3/item/database")
    {
    }
}