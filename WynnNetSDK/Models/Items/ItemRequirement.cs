using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

/// <summary>
/// Represents the level and stat requirements to use an item.
/// </summary>
public class ItemRequirement
{
    /// <summary>
    /// The minimum level required to use this item.
    /// </summary>
    [JsonPropertyName("level")]
    public int? Level { get; set; }

    /// <summary>
    /// The class required to use this item.
    /// </summary>
    [JsonPropertyName("classRequirement")]
    public string? ClassRequirement { get; set; }

    /// <summary>
    /// The minimum strength required.
    /// </summary>
    [JsonPropertyName("strength")]
    public int? Strength { get; set; }

    /// <summary>
    /// The minimum dexterity required.
    /// </summary>
    [JsonPropertyName("dexterity")]
    public int? Dexterity { get; set; }

    /// <summary>
    /// The minimum intelligence required.
    /// </summary>
    [JsonPropertyName("intelligence")]
    public int? Intelligence { get; set; }

    /// <summary>
    /// The minimum defence required.
    /// </summary>
    [JsonPropertyName("defence")]
    public int? Defence { get; set; }

    /// <summary>
    /// The minimum agility required.
    /// </summary>
    [JsonPropertyName("agility")]
    public int? Agility { get; set; }
}
