using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Represents an archetype specialization for a class in Wynncraft.
/// </summary>
public class Archtype
{
    /// <summary>
    /// The display name of the archetype.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } =  string.Empty;

    /// <summary>
    /// The full description of the archetype.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// A short summary of the archetype.
    /// </summary>
    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; } = string.Empty;

    /// <summary>
    /// The icon used to represent this archetype.
    /// </summary>
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();

    /// <summary>
    /// The slot number of this archetype in the class tree.
    /// </summary>
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
}
