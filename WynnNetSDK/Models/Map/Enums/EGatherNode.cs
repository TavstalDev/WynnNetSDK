using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Map.Enums;

/// <summary>
/// The shape type of a gather node on the map.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EGatherNode>))]
public enum EGatherNode
{
    /// <summary>
    /// A single point node.
    /// </summary>
    NODE,
    /// <summary>
    /// A wall-shaped node.
    /// </summary>
    WALL,
    /// <summary>
    /// A corner-shaped node.
    /// </summary>
    CORNER
}
