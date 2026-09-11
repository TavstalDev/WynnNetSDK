using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all world events from the Wynncraft API.
/// </summary>
public class MapListEventsRequest : HttpRequestBase<List<MapWorldEvent>>
{
    /// <summary>
    /// Creates a new request to list all world events.
    /// </summary>
    public MapListEventsRequest()
        : base(HttpMethod.Get, "/v3/map/world-events")
    {
    }
}
