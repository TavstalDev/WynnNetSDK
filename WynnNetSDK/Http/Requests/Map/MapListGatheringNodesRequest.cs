using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Requests.Map;

/// <summary>
/// A request to list all gathering nodes from the Wynncraft API.
/// </summary>
public class MapListGatheringNodesRequest : HttpRequestBase<List<MapGatherNode>>
{
    /// <summary>
    /// Creates a new request to list all gathering nodes.
    /// </summary>
    public MapListGatheringNodesRequest() 
        : base(HttpMethod.Get, "/v3/map/gathering-nodes")
    {
    }
}