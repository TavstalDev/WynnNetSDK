using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListEventsRequest : HttpRequestBase<List<MapWorldEvent>>
{
    public MapListEventsRequest() 
        : base(HttpMethod.Get, "/v3/map/world-events")
    {
    }
}