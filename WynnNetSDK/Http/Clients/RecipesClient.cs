using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http.Requests.Recipes;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Recipes.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class RecipesClient : HttpClientBase
{
    public RecipesClient(IWynnHttpClient client, ICacheManager? cacheManager = null) : base(client, cacheManager) { }
    
    public Task<Result<RecipeResult, ErrorResponse>> ListAsync(int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new RecipesListRequest(page, fullResult),  TimeSpan.FromHours(1), cancellationToken);

    public Task<Result<RecipeResult, ErrorResponse>> SearchAsync(RecipesSearchRequestBody requestBody, int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new RecipesSearchRequest(requestBody, page, fullResult),  TimeSpan.FromHours(1), cancellationToken);
}
