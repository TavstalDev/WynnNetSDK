using Tavstal.WynnNetSDK.Http.Requests.Map;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class MapClient : HttpClientBase
{
    public MapClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<List<MapCamp>, ErrorResponse>> ListCampsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListCampsRequest(level), cancellationToken);
    
    public Task<Result<List<MapWorldEvent>, ErrorResponse>> ListEventsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListEventsRequest(), cancellationToken);
    
    public Task<Result<List<MapGatherNode>, ErrorResponse>> ListGatheringNodesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListGatheringNodesRequest(), cancellationToken);
    
    public Task<Result<List<MapLootPool>, ErrorResponse>> ListLootPoolsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListLootPoolsRequest(level), cancellationToken);
    
    public Task<Result<List<MapMarker>, ErrorResponse>> ListMarkersAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListMarkersRequest(), cancellationToken);
    
    public Task<Result<List<MapPlayerInfo>, ErrorResponse>> ListPlayerLocationsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListPlayerLocationsRequest(), cancellationToken);
    
    public Task<Result<MapQuests, ErrorResponse>> ListQuestsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListQuestsRequest(), cancellationToken);
    
    public Task<Result<List<MapCamp>, ErrorResponse>> ListRaidsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListRaidsRequest(level), cancellationToken);
}
