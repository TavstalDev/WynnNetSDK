using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Recipes;

/// <summary>
/// Represents a visual sprite associated with a recipe item.
/// </summary>
public class Sprite
{
    /// <summary>
    /// The format of the sprite.
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; } = string.Empty;
    
    /// <summary>
    /// The name of the sprite.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The value data for the sprite.
    /// </summary>
    [JsonPropertyName("value")]
    public SpriteValue Value { get; set; } = new();
}