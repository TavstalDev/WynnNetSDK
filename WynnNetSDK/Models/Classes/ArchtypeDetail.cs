using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Contains detailed stats and information about a class archetype.
/// </summary>
public class ArchtypeDetail
{
    /// <summary>
    /// The display name of the archetype.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name {  get; set; } = string.Empty;

    /// <summary>
    /// The difficulty rating of this archetype.
    /// </summary>
    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }

    /// <summary>
    /// The maximum point value for this archetype.
    /// </summary>
    [JsonPropertyName("max")]
    public int Max { get; set; }

    /// <summary>
    /// The icon identifier for this archetype.
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;

    /// <summary>
    /// The base damage stat of this archetype.
    /// </summary>
    [JsonPropertyName("damage")]
    public int Damage { get; set; }

    /// <summary>
    /// The base defence stat of this archetype.
    /// </summary>
    [JsonPropertyName("defence")]
    public int Defence { get; set; }

    /// <summary>
    /// The base range stat of this archetype.
    /// </summary>
    [JsonPropertyName("range")]
    public int Range { get; set; }

    /// <summary>
    /// The base speed stat of this archetype.
    /// </summary>
    [JsonPropertyName("speed")]
    public int Speed { get; set; }
}
