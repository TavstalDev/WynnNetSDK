using Tavstal.WynnNetSDK.Models.Leaderboard;

namespace Tavstal.WynnNetSDK.Http.Requests.Leaderboard;

/// <summary>
/// A request to get a specific leaderboard from the Wynncraft API.
/// </summary>
public class LeaderboardGetRequest : HttpRequestBase<Dictionary<string, LeaderboardEntry>>
{
    /// <summary>
    /// Creates a new request to get a specific leaderboard.
    /// </summary>
    /// <param name="leaderboardType">The type of leaderboard to retrieve.</param>
    /// <param name="resultLimit">The maximum number of results to return. Between 1 and 1000.</param>
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