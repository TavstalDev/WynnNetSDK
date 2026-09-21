using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// The available player character classes in Wynncraft.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EClass>))]
public enum EClass
{
    /// <summary>
    /// The Archer class.
    /// </summary>
    [JsonPropertyName("archer")]
    ARCHER,
    /// <summary>
    /// The Warrior class.
    /// </summary>
    [JsonPropertyName("warrior")]
    WARRIOR,
    /// <summary>
    /// The Assassin class.
    /// </summary>
    [JsonPropertyName("assassin")]
    ASSASSIN,
    /// <summary>
    /// The Mage class.
    /// </summary>
    [JsonPropertyName("mage")]
    MAGE,
    /// <summary>
    /// The Shaman class.
    /// </summary>
    [JsonPropertyName("shaman")]
    SHAMAN
}
