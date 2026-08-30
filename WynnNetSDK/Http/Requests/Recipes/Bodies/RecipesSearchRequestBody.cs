using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;

public class RecipesSearchRequestBody
{
    [JsonPropertyName("query")] public List<string>? Query { get; set; }

    [JsonPropertyName("xp")] public List<int>? Xp { get; set; }

    [JsonPropertyName("type")] public List<string>? Type { get; set; }

    [JsonPropertyName("skill")] public List<string>? Skill { get; set; }

    [JsonPropertyName("materials")] public List<string>? Materials { get; set; }

    [JsonPropertyName("level")] public List<int>? Level { get; set; }

    [JsonPropertyName("durability")]
    public List<int>? Durability { get; set; }
    
    [JsonPropertyName("healthOrDamage")]
    public List<int>? HealthOrDamage { get; set; }
    
    [JsonPropertyName("duration")]
    public List<int>? Duration { get; set; }
    
    [JsonPropertyName("basicDuration")]
    public List<int>? BasicDuration { get; set; }
}