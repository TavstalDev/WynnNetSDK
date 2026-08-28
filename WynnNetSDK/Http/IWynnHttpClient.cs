using Tavstal.WynnNetSDK.Http.Clients;

namespace Tavstal.WynnNetSDK.Http;

public interface IWynnHttpClient
{
    AbilityClient Ability { get; }
    
    ClassesClient Classes { get; }
    
    GuildClient Guild { get; }
    
    ItemsClient Items { get; }
    
    LeaderboardClient Leaderboard { get; }
    
    MapClient Map { get; }
    
    NewsClient News { get; }
    
    PlayerClient Player { get; }
    
    SearchClient Search { get; }
    
    Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default);
}