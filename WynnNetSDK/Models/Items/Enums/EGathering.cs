using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the gathering skill type for an item.
/// </summary>
public enum EGathering
{
    /// <summary>
    /// Farming gathering skill.
    /// </summary>
    [JsonPropertyName("farming")]
    FARMING,

    /// <summary>
    /// Fishing gathering skill.
    /// </summary>
    [JsonPropertyName("fishing")]
    FISHING,

    /// <summary>
    /// Mining gathering skill.
    /// </summary>
    [JsonPropertyName("mining")]
    MINING,

    /// <summary>
    /// Woodcutting gathering skill.
    /// </summary>
    [JsonPropertyName("woodcutting")]
    WOODCUTTING
}
