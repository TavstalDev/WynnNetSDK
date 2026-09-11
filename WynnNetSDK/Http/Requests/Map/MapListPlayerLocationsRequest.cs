using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all player locations from the Wynncraft API.
/// </summary>
public class MapListPlayerLocationsRequest : HttpRequestBase<List<MapPlayerInfo>>
{
    /// <summary>
    /// Creates a new request to list all player locations.
    /// </summary>
    public MapListPlayerLocationsRequest()
        : base(HttpMethod.Get, "/v3/map/locations/player")
    {
    }
}
