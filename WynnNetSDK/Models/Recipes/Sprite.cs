using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Recipes;

public class Sprite
{
    [JsonPropertyName("format")]
    public string Format { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("value")]
    public SpriteValue Value { get; set; } = new();
}