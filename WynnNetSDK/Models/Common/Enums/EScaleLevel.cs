using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Common.Enums;

/// <summary>
/// Represents a scale level from very low to very high.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EScaleLevel>))]
public enum EScaleLevel
{
    /// <summary>
    /// A very low scale level.
    /// </summary>
    VERY_LOW = 0,

    /// <summary>
    /// A low scale level.
    /// </summary>
    LOW = 1,

    /// <summary>
    /// A medium scale level.
    /// </summary>
    MEDIUM = 2,

    /// <summary>
    /// A high scale level.
    /// </summary>
    HIGH = 3,

    /// <summary>
    /// A very high scale level.
    /// </summary>
    VERY_HIGH = 4
}
