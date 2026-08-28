namespace Tavstal.WynnNetSDK.Http.Requests.Leaderboard;

public class LeaderboardGetEntriesRequest : HttpRequestBase
{
    public LeaderboardGetEntriesRequest(string leaderboardType) 
        : base(HttpMethod.Get, $"/v3/leaderboards/{leaderboardType}")
    {
    }
}