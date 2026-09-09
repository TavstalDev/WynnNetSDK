using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// The available player character classes in Wynncraft.
/// </summary>
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
