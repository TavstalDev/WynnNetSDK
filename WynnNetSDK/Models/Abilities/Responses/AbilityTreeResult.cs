using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Models.Abilities.Responses;

/// <summary>
/// Represents the full ability tree data for a class.
/// </summary>
public class AbilityTreeResult
{
    /// <summary>
    /// The archetypes available in this ability tree.
    /// </summary>
    [JsonPropertyName("archtypes")]
    public Dictionary<string, Archtype> Archtypes { get; set; } = [];

    /// <summary>
    /// The ability pages in the tree, grouped by page number.
    /// </summary>
    [JsonPropertyName("pages")]
    public Dictionary<string, Dictionary<string, Ability>> Pages { get; set; } = [];
}
