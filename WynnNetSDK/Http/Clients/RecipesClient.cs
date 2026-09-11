using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Recipes;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Recipes.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

/// <summary>
/// Client for recipe-related API endpoints.
/// </summary>
public class RecipesClient : HttpClientBase
{
    /// <summary>
    /// Creates a new recipes client.
    /// </summary>
    /// <param name="client">The HTTP client used to send requests.</param>
    /// <param name="cacheManager">An optional cache manager for storing responses.</param>
    public RecipesClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }

    /// <summary>
    /// Lists recipes with optional pagination and result formatting.
    /// </summary>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result data.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A paginated result containing recipe data.</returns>
    public Task<Result<RecipeResult, ErrorResponse>> ListAsync(int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new RecipesListRequest(page, fullResult), TimeSpan.FromHours(1), cancellationToken);

    /// <summary>
    /// Searches for recipes using detailed filter criteria.
    /// </summary>
    /// <param name="requestBody">The search criteria to filter recipes by.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result data.</param>
    /// <param name="cancellationToken">A token to cancel the request.</param>
    /// <returns>A paginated result containing matching recipes.</returns>
    public Task<Result<RecipeResult, ErrorResponse>> SearchAsync(RecipesSearchRequestBody requestBody, int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new RecipesSearchRequest(requestBody, page, fullResult), TimeSpan.FromHours(1), cancellationToken);
}
