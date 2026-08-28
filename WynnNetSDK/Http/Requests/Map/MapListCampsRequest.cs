namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListCampsRequest : HttpRequestBase
{
    public MapListCampsRequest() 
        : base(HttpMethod.Get, "/v3/map/camps")
    {
    }
}