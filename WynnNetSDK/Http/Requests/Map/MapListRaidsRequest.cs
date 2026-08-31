using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListRaidsRequest : HttpRequestBase<List<MapCamp>>
{
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