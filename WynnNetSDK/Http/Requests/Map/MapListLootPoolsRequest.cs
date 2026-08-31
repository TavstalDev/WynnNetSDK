using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListLootPoolsRequest : HttpRequestBase<List<MapLootPool>>
{
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