using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Recipes.Responses;

/// <summary>
/// Represents the response from the recipes search endpoint.
/// </summary>
public class RecipeResult
{
    /// <summary>
    /// The pagination controller for navigating through results.
    /// </summary>
    [JsonPropertyName("controller")]
    public PageController Controller { get; set; } = new();

    /// <summary>
    /// The list of recipes matching the search query.
    /// </summary>
    [JsonPropertyName("results")]
    public List<Recipe> Results { get; set; } = [];
}
