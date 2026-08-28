namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListMarkersRequest : HttpRequestBase
{
    public MapListMarkersRequest() 
        : base(HttpMethod.Get, "/v3/map/locations/markers")
    {
    }
}