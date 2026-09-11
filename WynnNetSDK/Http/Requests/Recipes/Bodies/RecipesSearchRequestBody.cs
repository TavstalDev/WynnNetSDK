using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;

/// <summary>
/// The request body for searching recipes with filters.
/// </summary>
public class RecipesSearchRequestBody
{
    /// <summary>
    /// The search query to filter recipes by name.
    /// </summary>
    [JsonPropertyName("query")] public List<string>? Query { get; set; }

    /// <summary>
    /// The experience values to filter recipes by.
    /// </summary>
    [JsonPropertyName("xp")] public List<int>? Xp { get; set; }

    /// <summary>
    /// The recipe types to filter by.
    /// </summary>
    [JsonPropertyName("type")] public List<string>? Type { get; set; }

    /// <summary>
    /// The skills to filter recipes by.
    /// </summary>
    [JsonPropertyName("skill")] public List<string>? Skill { get; set; }

    /// <summary>
    /// The materials to filter recipes by.
    /// </summary>
    [JsonPropertyName("materials")] public List<string>? Materials { get; set; }

    /// <summary>
    /// The levels to filter recipes by.
    /// </summary>
    [JsonPropertyName("level")] public List<int>? Level { get; set; }

    /// <summary>
    /// The durability values to filter recipes by.
    /// </summary>
    [JsonPropertyName("durability")]
    public List<int>? Durability { get; set; }

    /// <summary>
    /// The health or damage values to filter recipes by.
    /// </summary>
    [JsonPropertyName("healthOrDamage")]
    public List<int>? HealthOrDamage { get; set; }

    /// <summary>
    /// The duration values to filter recipes by.
    /// </summary>
    [JsonPropertyName("duration")]
    public List<int>? Duration { get; set; }

    /// <summary>
    /// The basic duration values to filter recipes by.
    /// </summary>
    [JsonPropertyName("basicDuration")]
    public List<int>? BasicDuration { get; set; }
}
