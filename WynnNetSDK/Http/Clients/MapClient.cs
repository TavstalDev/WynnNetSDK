using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Map;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class MapClient : HttpClientBase
{
    public MapClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<List<MapCamp>, ErrorResponse>> ListCampsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListCampsRequest(level),  TimeSpan.FromMinutes(1), cancellationToken);
    
    public Task<Result<List<MapWorldEvent>, ErrorResponse>> ListEventsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListEventsRequest(),  TimeSpan.FromMinutes(2), cancellationToken);
    
    public Task<Result<List<MapGatherNode>, ErrorResponse>> ListGatheringNodesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListGatheringNodesRequest(),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<List<MapLootPool>, ErrorResponse>> ListLootPoolsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListLootPoolsRequest(level),  TimeSpan.FromMinutes(2), cancellationToken);
    
    public Task<Result<List<MapMarker>, ErrorResponse>> ListMarkersAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListMarkersRequest(), TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<List<MapPlayerInfo>, ErrorResponse>> ListPlayerLocationsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListPlayerLocationsRequest(),  TimeSpan.FromSeconds(15), cancellationToken);
    
    public Task<Result<MapQuests, ErrorResponse>> ListQuestsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListQuestsRequest(),  TimeSpan.FromHours(1), cancellationToken);
    
    public Task<Result<List<MapCamp>, ErrorResponse>> ListRaidsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListRaidsRequest(level),  TimeSpan.FromMinutes(1), cancellationToken);
}
