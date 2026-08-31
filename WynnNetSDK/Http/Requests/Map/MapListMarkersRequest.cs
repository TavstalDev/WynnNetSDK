using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListMarkersRequest : HttpRequestBase<List<MapMarker>>
{
    public MapListMarkersRequest() 
        : base(HttpMethod.Get, "/v3/map/locations/markers")
    {
    }
}