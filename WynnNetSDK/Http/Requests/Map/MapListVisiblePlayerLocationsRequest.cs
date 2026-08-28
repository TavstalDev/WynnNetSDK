namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListVisiblePlayerLocationsRequest : HttpRequestBase
{
    public MapListVisiblePlayerLocationsRequest() 
        : base(HttpMethod.Get, "/v3/map/locations/player")
    {
    }
}