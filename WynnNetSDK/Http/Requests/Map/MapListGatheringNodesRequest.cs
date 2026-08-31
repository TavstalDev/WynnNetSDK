using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListGatheringNodesRequest : HttpRequestBase<List<MapGatherNode>>
{
    public MapListGatheringNodesRequest() 
        : base(HttpMethod.Get, "/v3/map/gathering-nodes")
    {
    }
}