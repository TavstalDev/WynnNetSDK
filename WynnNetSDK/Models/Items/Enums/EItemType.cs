using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the main type of an item.
/// </summary>
public enum EItemType
{
    /// <summary>
    /// A weapon item.
    /// </summary>
    [JsonPropertyName("weapon")]
    WEAPON,

    /// <summary>
    /// An armour item.
    /// </summary>
    [JsonPropertyName("armour")]
    ARMOUR,

    /// <summary>
    /// An accessory item.
    /// </summary>
    [JsonPropertyName("accessory")]
    ACCESSORY,

    /// <summary>
    /// A charm item.
    /// </summary>
    [JsonPropertyName("charm")]
    CHARM,

    /// <summary>
    /// A tome item.
    /// </summary>
    [JsonPropertyName("tome")]
    TOME,

    /// <summary>
    /// A tool item.
    /// </summary>
    [JsonPropertyName("tool")]
    TOOL,

    /// <summary>
    /// A material item.
    /// </summary>
    [JsonPropertyName("material")]
    MATERIAL,

    /// <summary>
    /// An ingredient item.
    /// </summary>
    [JsonPropertyName("ingredient")]
    INGREDIENT
}
