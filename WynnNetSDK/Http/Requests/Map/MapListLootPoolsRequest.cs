namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListLootPoolsRequest : HttpRequestBase
{
    public MapListLootPoolsRequest() 
        : base(HttpMethod.Get, "/v3/map/loot-pools")
    {
    }
}