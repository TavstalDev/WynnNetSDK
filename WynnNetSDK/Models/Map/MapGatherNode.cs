using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a gather node on the Wynncraft map.
/// </summary>
public class MapGatherNode
{
    /// <summary>
    /// The X coordinate of the gather node.
    /// </summary>
    [JsonPropertyName("x")]
    public int X { get; set; }

    /// <summary>
    /// The Y coordinate of the gather node.
    /// </summary>
    [JsonPropertyName("y")]
    public int Y { get; set; }

    /// <summary>
    /// The Z coordinate of the gather node.
    /// </summary>
    [JsonPropertyName("z")]
    public int Z { get; set; }

    /// <summary>
    /// The angle of the gather node in degrees.
    /// </summary>
    [JsonPropertyName("angle")]
    public int Angle { get; set; }

    /// <summary>
    /// The shape type of the gather node.
    /// </summary>
    [JsonPropertyName("type")]
    public EGatherNode Type { get; set; }

    /// <summary>
    /// The resource name of the gather node.
    /// </summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; } = string.Empty;

    /// <summary>
    /// The required level to gather from this node.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }
}
