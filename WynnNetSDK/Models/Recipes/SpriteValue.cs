using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Recipes;

/// <summary>
/// Represents the value data of a sprite used in a recipe.
/// </summary>
public class SpriteValue
{
    /// <summary>
    /// The item identifier for the sprite.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    /// <summary>
    /// The display name of the sprite item.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The custom model data value for the sprite.
    /// </summary>
    [JsonPropertyName("customModelData")]
    public int CustomModelData { get; set; }
}