using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the attack speed of an item.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EAttackSpeed>))]
public enum EAttackSpeed
{
    /// <summary>
    /// Slow attack speed.
    /// </summary>
    [JsonPropertyName("slow")]
    SLOW,

    /// <summary>
    /// Fast attack speed.
    /// </summary>
    [JsonPropertyName("fast")]
    FAST,

    /// <summary>
    /// Super slow attack speed.
    /// </summary>
    [JsonPropertyName("superSlow")]
    SUPER_SLOW,

    /// <summary>
    /// Normal attack speed.
    /// </summary>
    [JsonPropertyName("normal")]
    NORMAL,

    /// <summary>
    /// Very slow attack speed.
    /// </summary>
    [JsonPropertyName("verySlow")]
    VERY_SLOW,

    /// <summary>
    /// Very fast attack speed.
    /// </summary>
    [JsonPropertyName("veryFast")]
    VERY_FAST,

    /// <summary>
    /// Super fast attack speed.
    /// </summary>
    [JsonPropertyName("superFast")]
    SUPER_FAST
}
