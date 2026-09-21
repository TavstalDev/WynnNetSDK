using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the rarity tier of an item.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<ETier>))]
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
    [JsonPropertyName("TIER_3")]
    TIER3,

    /// <summary>
    /// Tier 2.
    /// </summary>
    [JsonPropertyName("TIER_2")]
    TIER2,

    /// <summary>
    /// Tier 1.
    /// </summary>
    [JsonPropertyName("TIER_1")]
    TIER1,

    /// <summary>
    /// Tier 0.
    /// </summary>
    [JsonPropertyName("TIER_0")]
    TIER0
}
