using Tavstal.WynnNetSDK.Models.Recipes.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Recipes;

public class RecipesListRequest : HttpRequestBase<RecipeResult>
{
    public RecipesListRequest(int? page = null, bool? fullResult = null) 
        : base(HttpMethod.Get, "/v3/item/recipe/database")
    {
        List<string> queryParams = [];
        if (page is > 0)
            queryParams.Add($"page={page}");
        if (fullResult is true)
            queryParams.Add("full_result");
        
        if (queryParams.Count == 0)
            return;
        
        var queryString = string.Join("&", queryParams);
        RequestUri = new Uri(RequestUri + "?" + queryString, UriKind.Relative);
    }
}