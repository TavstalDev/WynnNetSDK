using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListQuestsRequest : HttpRequestBase<MapQuests>
{
    public MapListQuestsRequest() 
        : base(HttpMethod.Get, "/v3/map/quests")
    {
    }
}