using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapCamp
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public ECampType Type { get; set; }
    
    [JsonPropertyName("lore")]
    public string? Lore { get; set; }
    
    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }
    
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    
    [JsonPropertyName("length")]
    public string? Length { get; set; }
    
    [JsonPropertyName("requirements")]
    public List<WorldEventRequirement>? Requirements { get; set; }
    
    [JsonPropertyName("location")]
    public Vector3? Location { get; set; }
    
    [JsonPropertyName("rewards")]
    public List<CampReward> Rewards { get; set; } = [];
}