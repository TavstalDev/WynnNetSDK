using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Abilities;

/// <summary>
/// Represents a node in the ability tree for a class.
/// </summary>
public class AbilityNode
{
    /// <summary>
    /// The type of this ability node.
    /// </summary>
    [JsonPropertyName("type")]
    public EAbilityType Type { get; set; }

    /// <summary>
    /// The position of this node on the ability map.
    /// </summary>
    [JsonPropertyName("coordinates")]
    public Vector2 Coordinates { get; set; } = new();

    /// <summary>
    /// The metadata for this ability node.
    /// </summary>
    [JsonPropertyName("meta")]
    public AbilityNodeMeta Meta { get; set; } = new();

    /// <summary>
    /// The family group this node belongs to.
    /// </summary>
    [JsonPropertyName("family")]
    public List<string> Family { get; set; } = [];
}
