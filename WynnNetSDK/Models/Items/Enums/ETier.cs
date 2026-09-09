using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the rarity tier of an item.
/// </summary>
public enum ETier
{
    /// <summary>
    /// Rare tier.
    /// </summary>
    [JsonPropertyName("rare")]
    RARE,

    /// <summary>
    /// Unique tier.
    /// </summary>
    [JsonPropertyName("unique")]
    UNIQUE,

    /// <summary>
    /// Normal tier.
    /// </summary>
    [JsonPropertyName("normal")]
    NORMAL,

    /// <summary>
    /// Legendary tier.
    /// </summary>
    [JsonPropertyName("legendary")]
    LEGENDARY,

    /// <summary>
    /// Mythic tier.
    /// </summary>
    [JsonPropertyName("mythic")]
    MYTHIC,

    /// <summary>
    /// Fabled tier.
    /// </summary>
    [JsonPropertyName("fabled")]
    FABLED,

    /// <summary>
    /// Tier 3.
    /// </summary>
    TIER3,

    /// <summary>
    /// Tier 2.
    /// </summary>
    TIER2,

    /// <summary>
    /// Tier 1.
    /// </summary>
    TIER1,

    /// <summary>
    /// Tier 0.
    /// </summary>
    TIER0
}
