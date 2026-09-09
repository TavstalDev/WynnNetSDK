using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Recipes;

/// <summary>
/// Represents a Wynncraft crafting recipe.
/// </summary>
public class Recipe
{
    /// <summary>
    /// The internal name of the item produced by this recipe.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    /// <summary>
    /// The type of item this recipe produces.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type  { get; set; } = string.Empty;
    
    /// <summary>
    /// The profession skill required to use this recipe.
    /// </summary>
    [JsonPropertyName("skill")]
    public string Skill { get; set; } = string.Empty;
    
    /// <summary>
    /// The list of materials required to craft this recipe.
    /// </summary>
    [JsonPropertyName("materials")]
    public List<Material> Materials { get; set; } = [];
    
    /// <summary>
    /// The health or damage range of the crafted item.
    /// </summary>
    [JsonPropertyName("healthOrDamage")]
    public IntRange HealthOrDamage { get; set; } = new();
    
    /// <summary>
    /// The sprites associated with this recipe.
    /// </summary>
    [JsonPropertyName("sprites")]
    public Dictionary<string, Sprite> Sprites { get; set; } = new();
    
    /// <summary>
    /// The experience points gained from crafting this recipe.
    /// </summary>
    [JsonPropertyName("xp")]
    public int Xp { get; set; }
    
    /// <summary>
    /// The durability range of the crafted item, or null if not applicable.
    /// </summary>
    [JsonPropertyName("durability")]
    public IntRange? Durability { get; set; }
    
    /// <summary>
    /// The duration range of the crafted item, or null if not applicable.
    /// </summary>
    [JsonPropertyName("duration")]
    public IntRange? Duration { get; set; }
    
    /// <summary>
    /// The basic duration range of the crafted item, or null if not applicable.
    /// </summary>
    [JsonPropertyName("basicDuration")]
    public IntRange? BasicDuration { get; set; }
}