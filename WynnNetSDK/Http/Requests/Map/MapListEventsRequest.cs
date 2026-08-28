namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListEventsRequest : HttpRequestBase
{
    public MapListEventsRequest() 
        : base(HttpMethod.Get, "/v3/map/world-events")
    {
    }
}