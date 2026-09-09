using Tavstal.WynnNetSDK.Http.Clients;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Defines the methods and properties available on the Wynncraft HTTP client.
/// </summary>
public interface IWynnHttpClient
{
    /// <summary>Client for ability-related API endpoints.</summary>
    AbilityClient Ability { get; }
    
    /// <summary>Client for class-related API endpoints.</summary>
    ClassesClient Classes { get; }
    
    /// <summary>Client for guild-related API endpoints.</summary>
    GuildClient Guild { get; }
    
    /// <summary>Client for item-related API endpoints.</summary>
    ItemsClient Items { get; }
    
    /// <summary>Client for leaderboard-related API endpoints.</summary>
    LeaderboardClient Leaderboard { get; }
    
    /// <summary>Client for map-related API endpoints.</summary>
    MapClient Map { get; }
    
    /// <summary>Client for news-related API endpoints.</summary>
    NewsClient News { get; }
    
    /// <summary>Client for player-related API endpoints.</summary>
    PlayerClient Player { get; }
    
    /// <summary>Client for recipe-related API endpoints.</summary>
    RecipesClient Recipes { get; }
    
    /// <summary>Client for the search API endpoint.</summary>
    SearchClient Search { get; }
    
    /// <summary>
    /// Sends an HTTP request to the Wynncraft API and returns the raw response.
    /// </summary>
    /// <param name="request">The request to send.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The HTTP response message.</returns>
    Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default);
}