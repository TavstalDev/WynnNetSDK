using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Responses;

/// <summary>
/// Represents static metadata for items, mapping names to their occurrence counts.
/// </summary>
public class ItemMetaStaticResult
{
    /// <summary>
    /// The attack speed values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("attackSpeed")]
    public Dictionary<string, int> AttackSpeed { get; set; } = [];

    /// <summary>
    /// The emblem values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("emblem")]
    public Dictionary<string, int> Emblem { get; set; } = [];

    /// <summary>
    /// The gathering skill values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("gathering")]
    public Dictionary<string, int> Gathering { get; set; } = [];

    /// <summary>
    /// The identification values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("identifications")]
    public Dictionary<string, int> Identifications { get; set; } = [];

    /// <summary>
    /// The major ID values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("majorIds")]
    public Dictionary<string, int> MajorIds { get; set; } = [];

    /// <summary>
    /// The item set values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("set")]
    public Dictionary<string, int> Set { get; set; } = [];

    /// <summary>
    /// The sub type values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("subType")]
    public Dictionary<string, int> SubType { get; set; } = [];

    /// <summary>
    /// The tier values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("tier")]
    public Dictionary<string, int> Tier { get; set; } = [];

    /// <summary>
    /// The item type values and their occurrence counts.
    /// </summary>
    [JsonPropertyName("type")]
    public Dictionary<string, int> Type { get; set; } = [];
}
