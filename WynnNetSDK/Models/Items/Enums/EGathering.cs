using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

public enum EGathering
{
    [JsonPropertyName("farming")]
    FARMING,
    [JsonPropertyName("fishing")]
    FISHING,
    [JsonPropertyName("mining")]
    MINING,
    [JsonPropertyName("woodcutting")]
    WOODCUTTING
}
