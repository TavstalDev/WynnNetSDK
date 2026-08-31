using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

public enum EClass
{
    [JsonPropertyName("archer")]
    ARCHER,
    [JsonPropertyName("warrior")]
    WARRIOR,
    [JsonPropertyName("assassin")]
    ASSASSIN,
    [JsonPropertyName("mage")]
    MAGE,
    [JsonPropertyName("shaman")]
    SHAMAN
}
