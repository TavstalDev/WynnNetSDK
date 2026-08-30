using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Recipes.Responses;

public class RecipeResult
{
    [JsonPropertyName("controller")]
    public PageController Controller { get; set; } = new();
    
    [JsonPropertyName("results")]
    public List<Recipe> Results { get; set; } = [];
}