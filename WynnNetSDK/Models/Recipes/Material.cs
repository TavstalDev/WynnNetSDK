using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Recipes;

/// <summary>
/// Represents a crafting material required by a recipe.
/// </summary>
public class Material
{
    /// <summary>
    /// The internal name of the required item.
    /// </summary>
    [JsonPropertyName("item")]
    public string Item { get; set; } = string.Empty;

    /// <summary>
    /// The quantity of the item needed.
    /// </summary>
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}
