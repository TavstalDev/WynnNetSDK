using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Abilities;

/// <summary>
/// Represents an ability in the Wynncraft ability tree.
/// </summary>
public class Ability
{
    /// <summary>
    /// The display name of the ability.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The icon used to represent this ability.
    /// </summary>
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();

    /// <summary>
    /// The slot number of this ability in the tree.
    /// </summary>
    [JsonPropertyName("slot")]
    public int Slot { get; set; }

    /// <summary>
    /// The position of this ability on the ability map.
    /// </summary>
    [JsonPropertyName("coordinates")]
    public Vector2 Coordinates { get; set; } = new();

    /// <summary>
    /// The description lines shown for this ability.
    /// </summary>
    [JsonPropertyName("description")]
    public List<string> Description { get; set; } = [];

    /// <summary>
    /// The skill point requirements to unlock this ability.
    /// </summary>
    [JsonPropertyName("requirements")]
    public Dictionary<string, int> Requirements { get; set; } = [];

    /// <summary>
    /// The IDs of abilities that this ability connects to.
    /// </summary>
    [JsonPropertyName("links")]
    public List<string> Links {  get; set; } = [];

    /// <summary>
    /// The IDs of abilities that this ability locks when taken.
    /// </summary>
    [JsonPropertyName("locks")]
    public List<string>? Locks { get; set; }

    /// <summary>
    /// The page number of the ability tree where this ability appears.
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }
}
