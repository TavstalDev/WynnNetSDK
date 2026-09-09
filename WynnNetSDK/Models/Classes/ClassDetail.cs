using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Contains detailed information about a player character class.
/// </summary>
public class ClassDetail
{
    /// <summary>
    /// The unique identifier of the class.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// The display name of the class.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The lore text describing the class.
    /// </summary>
    [JsonPropertyName("lore")]
    public string Lore { get; set; } = string.Empty;

    /// <summary>
    /// The overall difficulty rating of the class.
    /// </summary>
    [JsonPropertyName("overallDifficulty")]
    public int OverallyDifficulty {  get; set; }

    /// <summary>
    /// The maximum overall stat value for this class.
    /// </summary>
    [JsonPropertyName("overallMax")]
    public int OverallMax { get; set; }

    /// <summary>
    /// The archetype specializations available to this class.
    /// </summary>
    [JsonPropertyName("archtypes")]
    public Dictionary<string, ArchtypeDetail> Archtypes { get; set; } = [];
}
