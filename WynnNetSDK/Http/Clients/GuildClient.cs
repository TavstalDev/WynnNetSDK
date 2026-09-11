using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Guild;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for guild-related API endpoints.
/// </summary>
public class GuildClient : HttpClientBase
{
    /// <summary>
    /// Creates a new guild client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public GuildClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Gets detailed information about a guild by its name.
    /// </summary>
    /// <param name="query">The name of the guild to search for.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>Detailed information about the matching guild.</returns>
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByNameAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetByNameRequest(query), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Gets detailed information about a guild by its UUID.
    /// </summary>
    /// <param name="query">The UUID of the guild to look up.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>Detailed information about the matching guild.</returns>
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByUuidAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetByUuidRequest(query), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Gets detailed information about a guild by its prefix.
    /// </summary>
    /// <param name="query">The prefix of the guild to search for.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>Detailed information about the matching guild.</returns>
    public Task<Result<GuildDetailedInfo, ErrorResponse>> GetByPrefixAsync(string query, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildGetPrefixRequest(query), TimeSpan.FromSeconds(120), cancellationToken);

    /// <summary>
    /// Lists all guilds with optional filtering by identifier type.
    /// </summary>
    /// <param name="identifier">An optional identifier type to filter results by.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping guild names to guild result data.</returns>
    public Task<Result<Dictionary<string, GuildResult>, ErrorResponse>> ListAsync(EIdentifier? identifier = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListRequest(identifier), TimeSpan.FromHours(1), cancellationToken);

    /// <summary>
    /// Lists all available guild seasons.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping season identifiers to season data.</returns>
    public Task<Result<Dictionary<string, GuildSeason>, ErrorResponse>> ListSeasonsAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListSeasonsRequest(), TimeSpan.FromMinutes(10), cancellationToken);

    /// <summary>
    /// Lists all guild territories on the map.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping territory IDs to territory data.</returns>
    public Task<Result<Dictionary<string, GuildTerritory>, ErrorResponse>> ListTerritoriesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new GuildListTerritoriesRequest(), TimeSpan.FromSeconds(10), cancellationToken);
}
