using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all raids from the Wynncraft API.
/// </summary>
public class MapListRaidsRequest : HttpRequestBase<List<MapCamp>>
{
    /// <summary>
    /// Creates a new request to list all raids.
    /// </summary>
    /// <param name="level">The level to filter raids by.</param>
    public MapListRaidsRequest(int? level = null)
        : base(HttpMethod.Get, "/v3/map/raids")
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