using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all loot pools from the Wynncraft API.
/// </summary>
public class MapListLootPoolsRequest : HttpRequestBase<List<MapLootPool>>
{
    /// <summary>
    /// Creates a new request to list all loot pools.
    /// </summary>
    /// <param name="level">The level to filter loot pools by.</param>
    public MapListLootPoolsRequest(int? level = null)
        : base(HttpMethod.Get, "/v3/map/loot-pools")
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