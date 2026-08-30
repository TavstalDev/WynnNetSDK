namespace Tavstal.WynnNetSDK.Http.Requests.Leaderboard;

public class LeaderboardListRequest : HttpRequestBase<List<string>>
{
    public LeaderboardListRequest() 
        : base(HttpMethod.Get, "/v3/leaderboards/types")
    {
    }
}