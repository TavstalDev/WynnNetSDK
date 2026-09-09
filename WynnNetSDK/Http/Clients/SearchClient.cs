using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Search;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for general search API endpoints.
/// </summary>
public class SearchClient : HttpClientBase
{
    /// <summary>
    /// Creates a new search client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public SearchClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    /// <summary>
    /// Searches across all entities in Wynncraft.
    /// </summary>
    /// <param name="query">The search query to match against.</param>
    /// <param name="onlyOneResult">Whether to return only the single best match.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>The search result containing matching entities.</returns>
    public Task<Result<SearchResult, ErrorResponse>> SearchAsync(string query, bool onlyOneResult = false, CancellationToken cancellationToken = default)
        => ExecuteAsync(new SearchRequest(query, onlyOneResult),  TimeSpan.FromMinutes(10), cancellationToken);
}
