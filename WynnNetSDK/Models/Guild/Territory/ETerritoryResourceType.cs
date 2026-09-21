using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Guild.Territory;

/// <summary>
/// Represents the type of resource a territory can produce.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<ETerritoryResourceType>))]
public enum ETerritoryResourceType
{
    /// <summary>
    /// Emerald resource.
    /// </summary>
    EMERALD = 0,

    /// <summary>
    /// Ore resource.
    /// </summary>
    ORE = 1,

    /// <summary>
    /// Wood resource.
    /// </summary>
    WOOD = 2,

    /// <summary>
    /// Fish resource.
    /// </summary>
    FISH = 3,

    /// <summary>
    /// Crop resource.
    /// </summary>
    CROP = 4
}
