using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Recipes;

public class SpriteValue
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("customModelData")]
    public int CustomModelData { get; set; }
}