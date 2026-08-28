namespace Tavstal.WynnNetSDK.Http.Requests.Map;

public class MapListGatheringNodesRequest : HttpRequestBase
{
    public MapListGatheringNodesRequest() 
        : base(HttpMethod.Get, "/v3/map/gathering-nodes")
    {
    }
}