using System.Net.Http.Json;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Recipes.Responses;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Recipes;

/// <summary>
/// A request to search for recipes from the Wynncraft API.
/// </summary>
public class RecipesSearchRequest : HttpRequestBase<RecipeResult>
{
    /// <summary>
    /// Creates a new request to search for recipes.
    /// </summary>
    /// <param name="requestBody">The search criteria to filter recipes.</param>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="fullResult">Whether to return the full result without pagination.</param>
    public RecipesSearchRequest(RecipesSearchRequestBody requestBody, int? page = null, bool? fullResult = null)
        : base(HttpMethod.Post, "/v3/item/recipe/search", requestBody)
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
