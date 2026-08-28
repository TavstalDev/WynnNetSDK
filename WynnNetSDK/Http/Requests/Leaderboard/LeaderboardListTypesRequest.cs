namespace Tavstal.WynnNetSDK.Http.Requests.Leaderboard;

public class LeaderboardListTypesRequest : HttpRequestBase
{
    public LeaderboardListTypesRequest() 
        : base(HttpMethod.Get, "/v3/leaderboards/types")
    {
    }
}