using Tavstal.WynnNetSDK.Http.Requests.Leaderboard;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Leaderboard;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class LeaderboardClient : HttpClientBase
{
    public LeaderboardClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<List<string>, ErrorResponse>> ListTypesAsync(CancellationToken cancellationToken = default)
        => ExecuteAsync(new LeaderboardListRequest(), cancellationToken);
    
    public Task<Result<Dictionary<string, LeaderboardEntry>, ErrorResponse>> GetAsync(string leaderboardType, int resultLimit = 100, CancellationToken cancellationToken = default)
        => ExecuteAsync(new LeaderboardGetRequest(leaderboardType, resultLimit), cancellationToken);
}
