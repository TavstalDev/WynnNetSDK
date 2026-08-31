using Tavstal.WynnNetSDK.Http.Requests.Recipes;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Recipes.Responses;

namespace Tavstal.WynnNetSDK.Http.Clients;

public class RecipesClient : HttpClientBase
{
    public RecipesClient(IWynnHttpClient client) : base(client) { }
    
    public Task<Result<RecipeResult, ErrorResponse>> ListAsync(int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new RecipesListRequest(page, fullResult), cancellationToken);

    public Task<Result<RecipeResult, ErrorResponse>> SearchAsync(RecipesSearchRequestBody requestBody, int? page = null, bool? fullResult = null, CancellationToken cancellationToken = default)
        => ExecuteAsync(new RecipesSearchRequest(requestBody, page, fullResult), cancellationToken);
}
