using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapWorldEvent
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("lore")]
    public string Lore { get; set; } = string.Empty;
    
    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }
    
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    
    [JsonPropertyName("length")]
    public string? Length { get; set; }
    
    [JsonPropertyName("rewardPerLevel")]
    public Dictionary<string, List<string>>? RewardPerLevel { get; set; }
    
    [JsonPropertyName("requirements")]
    public List<WorldEventRequirement>? Requirements { get; set; }
    
    [JsonPropertyName("location")]
    public List<WorldEventLocation> Location { get; set; } = [];
    
    [JsonPropertyName("schedule")]
    public DateTime? Schedule { get; set; }
}