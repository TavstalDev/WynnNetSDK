namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListRaidsRequest : HttpRequestBase
{
    public MapListRaidsRequest() 
        : base(HttpMethod.Get, "/v3/map/raids")
    {
    }
}