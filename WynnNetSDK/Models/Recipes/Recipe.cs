using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Recipes;

public class Recipe
{
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public string Type  { get; set; } = string.Empty;
    
    [JsonPropertyName("skill")]
    public string Skill { get; set; } = string.Empty;
    
    [JsonPropertyName("materials")]
    public List<Material> Materials { get; set; } = [];
    
    [JsonPropertyName("healthOrDamage")]
    public IntRange HealthOrDamage { get; set; } = new();
    
    [JsonPropertyName("sprites")]
    public Dictionary<string, Sprite> Sprites { get; set; } = new();
    
    [JsonPropertyName("xp")]
    public int Xp { get; set; }
    
    [JsonPropertyName("durability")]
    public IntRange? Durability { get; set; }
    
    [JsonPropertyName("duration")]
    public IntRange? Duration { get; set; }
    
    [JsonPropertyName("basicDuration")]
    public IntRange? BasicDuration { get; set; }
}