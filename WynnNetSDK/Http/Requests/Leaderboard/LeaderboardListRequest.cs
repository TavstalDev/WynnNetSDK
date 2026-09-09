namespace Tavstal.WynnNetSDK.Http.Requests.Leaderboard;

/// <summary>
/// A request to list all available leaderboard types from the Wynncraft API.
/// </summary>
public class LeaderboardListRequest : HttpRequestBase<List<string>>
{
    /// <summary>
    /// Creates a new request to list all available leaderboard types.
    /// </summary>
    public LeaderboardListRequest() 
        : base(HttpMethod.Get, "/v3/leaderboards/types")
    {
    }
}