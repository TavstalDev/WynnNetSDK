using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all map camps from the Wynncraft API.
/// </summary>
public class MapListCampsRequest : HttpRequestBase<List<MapCamp>>
{
    /// <summary>
    /// Creates a new request to list all map camps.
    /// </summary>
    /// <param name="level">The level to filter camps by.</param>
    public MapListCampsRequest(int? level = null)
        : base(HttpMethod.Get, "/v3/map/camps")
    {
        List<string> queryParams = [];
        if (level != null)
            queryParams.Add($"level={level}");

        if (queryParams.Count == 0)
            return;

        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}
