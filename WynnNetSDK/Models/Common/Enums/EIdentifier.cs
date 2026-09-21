using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Common.Enums;

/// <summary>
/// Identifies how a player or guild is referenced.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EIdentifier>))]
public enum EIdentifier
{
    /// <summary>
    /// Identified by name.
    /// </summary>
    NAME = 0,

    /// <summary>
    /// Identified by UUID.
    /// </summary>
    UUID = 1
}
