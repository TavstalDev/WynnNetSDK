using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Map;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Map;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for map-related API endpoints.
/// </summary>
public class MapClient : HttpClientBase
{
    /// <summary>
    /// Creates a new map client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public MapClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    /// <summary>
    /// Lists camps on the map, optionally filtered by level.
    /// </summary>
    /// <param name="level">An optional level to filter camps by.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of map camp data.</returns>
    public Task<Result<List<MapCamp>, ErrorResponse>> ListCampsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListCampsRequest(level),  TimeSpan.FromMinutes(1), cancellationToken);
    
    /// <summary>
    /// Lists active world events on the map.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of map world event data.</returns>
    public Task<Result<List<MapWorldEvent>, ErrorResponse>> ListEventsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListEventsRequest(),  TimeSpan.FromMinutes(2), cancellationToken);
    
    /// <summary>
    /// Lists gathering nodes on the map.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of map gathering node data.</returns>
    public Task<Result<List<MapGatherNode>, ErrorResponse>> ListGatheringNodesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListGatheringNodesRequest(),  TimeSpan.FromHours(1), cancellationToken);
    
    /// <summary>
    /// Lists loot pools on the map, optionally filtered by level.
    /// </summary>
    /// <param name="level">An optional level to filter loot pools by.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of map loot pool data.</returns>
    public Task<Result<List<MapLootPool>, ErrorResponse>> ListLootPoolsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListLootPoolsRequest(level),  TimeSpan.FromMinutes(2), cancellationToken);
    
    /// <summary>
    /// Lists markers on the map.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of map marker data.</returns>
    public Task<Result<List<MapMarker>, ErrorResponse>> ListMarkersAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListMarkersRequest(), TimeSpan.FromHours(1), cancellationToken);
    
    /// <summary>
    /// Lists the current locations of online players on the map.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of player location data.</returns>
    public Task<Result<List<MapPlayerInfo>, ErrorResponse>> ListPlayerLocationsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListPlayerLocationsRequest(),  TimeSpan.FromSeconds(15), cancellationToken);
    
    /// <summary>
    /// Lists quests available on the map.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>The map quests data.</returns>
    public Task<Result<MapQuests, ErrorResponse>> ListQuestsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListQuestsRequest(),  TimeSpan.FromHours(1), cancellationToken);
    
    /// <summary>
    /// Lists raids on the map, optionally filtered by level.
    /// </summary>
    /// <param name="level">An optional level to filter raids by.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of map camp data for raids.</returns>
    public Task<Result<List<MapCamp>, ErrorResponse>> ListRaidsAsync(int? level = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new MapListRaidsRequest(level),  TimeSpan.FromMinutes(1), cancellationToken);
}
