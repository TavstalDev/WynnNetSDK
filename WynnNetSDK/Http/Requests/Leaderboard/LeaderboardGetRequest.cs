namespace Tavstal.WynnNetSDK.Http.Requests.Leaderboard;

public class LeaderboardGetRequest : HttpRequestBase
{
    public LeaderboardGetRequest(string leaderboardType, int resultLimit = 100) 
        : base(HttpMethod.Get, $"/v3/leaderboards/{leaderboardType}")
    {
        List<string> queryParams = [];
        if (resultLimit < 0)
            resultLimit = 100;
        if (resultLimit > 1000)
            resultLimit = 1000;
        queryParams.Add($"resultLimit={resultLimit}");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}