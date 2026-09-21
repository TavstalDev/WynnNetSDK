using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Common.Enums;

/// <summary>
/// Represents the colour of an item or text.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EColor>))]
public enum EColor
{
    /// <summary>
    /// The colour black.
    /// </summary>
    BLACK = 0,

    /// <summary>
    /// The colour red.
    /// </summary>
    RED = 1,

    /// <summary>
    /// The colour green.
    /// </summary>
    GREEN = 2,

    /// <summary>
    /// The colour brown.
    /// </summary>
    BROWN = 3,

    /// <summary>
    /// The colour blue.
    /// </summary>
    BLUE = 4,

    /// <summary>
    /// The colour purple.
    /// </summary>
    PURPLE = 5,

    /// <summary>
    /// The colour cyan.
    /// </summary>
    CYAN = 6,

    /// <summary>
    /// The colour silver.
    /// </summary>
    SILVER = 7,

    /// <summary>
    /// The colour gray.
    /// </summary>
    GRAY = 8,

    /// <summary>
    /// The colour pink.
    /// </summary>
    PINK = 9,

    /// <summary>
    /// The colour lime.
    /// </summary>
    LIME = 10,

    /// <summary>
    /// The colour yellow.
    /// </summary>
    YELLOW = 11,

    /// <summary>
    /// The colour light blue.
    /// </summary>
    LIGHT_BLUE = 12,

    /// <summary>
    /// The colour magenta.
    /// </summary>
    MAGENTA = 13,

    /// <summary>
    /// The colour orange.
    /// </summary>
    ORANGE = 14,

    /// <summary>
    /// The colour white.
    /// </summary>
    WHITE = 15
}
