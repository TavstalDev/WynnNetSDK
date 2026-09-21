using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Map.Enums;

/// <summary>
/// The type of a camp on the Wynncraft map.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<ECampType>))]
public enum ECampType
{
    /// <summary>
    /// A standard camp.
    /// </summary>
    CAMP,
    /// <summary>
    /// A raid camp.
    /// </summary>
    RAID
}
