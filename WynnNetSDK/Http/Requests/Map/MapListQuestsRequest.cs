namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListQuestsRequest : HttpRequestBase
{
    public MapListQuestsRequest() 
        : base(HttpMethod.Get, "/v3/map/quests")
    {
    }
}