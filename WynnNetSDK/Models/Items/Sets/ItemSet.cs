using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Sets;

/// <summary>
/// Represents an item set with its bonuses and parts.
/// </summary>
public class ItemSet
{
    /// <summary>
    /// The internal name of the item set.
    /// </summary>
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;

    /// <summary>
    /// The set bonuses keyed by the number of pieces required.
    /// </summary>
    [JsonPropertyName("bonuses")]
    public Dictionary<string, ItemSetBonus> Bonuses { get; set; } = new();

    /// <summary>
    /// The list of item internal names that belong to this set.
    /// </summary>
    [JsonPropertyName("parts")]
    public List<string> Parts { get; set; } = [];
}
