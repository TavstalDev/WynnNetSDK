using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

public enum EAttackSpeed
{
    [JsonPropertyName("slow")]
    SLOW,
    [JsonPropertyName("fast")]
    FAST,
    [JsonPropertyName("superSlow")]
    SUPER_SLOW,
    [JsonPropertyName("normal")]
    NORMAL,
    [JsonPropertyName("verySlow")]
    VERY_SLOW,
    [JsonPropertyName("veryFast")]
    VERY_FAST,
    [JsonPropertyName("superFast")]
    SUPER_FAST
}
