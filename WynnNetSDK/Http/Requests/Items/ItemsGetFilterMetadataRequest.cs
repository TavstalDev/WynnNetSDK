namespace Tavstal.WynnNetSDK.Http.Requests.Items;

public class ItemsGetFilterMetadataRequest : HttpRequestBase
{
    public ItemsGetFilterMetadataRequest() 
        : base(HttpMethod.Get, "/v3/item/metadata")
    {
    }
}