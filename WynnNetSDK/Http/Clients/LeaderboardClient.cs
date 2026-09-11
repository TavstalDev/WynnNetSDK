using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Leaderboard;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Leaderboard;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for leaderboard-related API endpoints.
/// </summary>
public class LeaderboardClient : HttpClientBase
{
    /// <summary>
    /// Creates a new leaderboard client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public LeaderboardClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Lists all available leaderboard types.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A list of leaderboard type names.</returns>
    public Task<Result<List<string>, ErrorResponse>> ListTypesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new LeaderboardListRequest(), TimeSpan.FromMinutes(10), cancellationToken);

    /// <summary>
    /// Gets leaderboard entries for a specific leaderboard type.
    /// </summary>
    /// <param name="leaderboardType">The type of leaderboard to retrieve.</param>
    /// <param name="resultLimit">The maximum number of results to return.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A dictionary mapping rank positions to leaderboard entries.</returns>
    public Task<Result<Dictionary<string, LeaderboardEntry>, ErrorResponse>> GetAsync(string leaderboardType, int resultLimit = 100, CancellationToken cancellationToken = default)
        => ExecuteAsync(new LeaderboardGetRequest(leaderboardType, resultLimit), TimeSpan.FromMinutes(10), cancellationToken);
}
