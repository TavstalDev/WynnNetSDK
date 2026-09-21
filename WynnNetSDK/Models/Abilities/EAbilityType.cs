using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Abilities;

/// <summary>
/// The type of a node in the ability tree.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EAbilityType>))]
public enum EAbilityType
{
    /// <summary>
    /// An ability that can be unlocked in the tree.
    /// </summary>
    ABILITY = 0,
    /// <summary>
    /// A line that connects two abilities in the tree.
    /// </summary>
    CONNECTOR = 1
}
