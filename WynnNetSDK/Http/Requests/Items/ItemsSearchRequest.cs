namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsSearchRequest : HttpRequestBase
{
    public ItemsSearchRequest() 
        : base(HttpMethod.Post, "/v3/item/search")
    {
    }
}