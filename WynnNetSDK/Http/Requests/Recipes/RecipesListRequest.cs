using Tavstal.WynnNetSDK.Models.Recipes.Responses;

namespace Tavstal.WynnNetSDK.Http.Requests.Recipes;

/// <summary>
/// A request to list all recipes from the Wynncraft API.
/// </summary>
public class RecipesListRequest : HttpRequestBase<RecipeResult>
{
    /// <summary>
    /// Creates a new request to list all recipes.
    /// </summary>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result without pagination.</param>
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
