using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListPlayerLocationsRequest : HttpRequestBase<List<MapPlayerInfo>>
{
    public MapListPlayerLocationsRequest() 
        : base(HttpMethod.Get, "/v3/map/locations/player")
    {
    }
}