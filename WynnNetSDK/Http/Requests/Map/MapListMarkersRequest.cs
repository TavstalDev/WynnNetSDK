using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all map markers from the Wynncraft API.
/// </summary>
public class MapListMarkersRequest : HttpRequestBase<List<MapMarker>>
{
    /// <summary>
    /// Creates a new request to list all map markers.
    /// </summary>
    public MapListMarkersRequest() 
        : base(HttpMethod.Get, "/v3/map/locations/markers")
    {
    }
}