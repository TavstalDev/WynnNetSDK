using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

public enum ETier
{
    [JsonPropertyName("rare")]
    RARE,
    [JsonPropertyName("unique")]
    UNIQUE,
    [JsonPropertyName("normal")]
    NORMAL,
    [JsonPropertyName("legendary")]
    LEGENDARY,
    [JsonPropertyName("mythic")]
    MYTHIC,
    [JsonPropertyName("fabled")]
    FABLED,
    TIER3,
    TIER2,
    TIER1,
    TIER0
}
