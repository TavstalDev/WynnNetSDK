using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Represents the skill point distribution for a class.
/// </summary>
public class SkillPoints
{
    /// <summary>
    /// The amount of strength skill points.
    /// </summary>
    [JsonPropertyName("strength")]
    public int Strength { get; set; }

    /// <summary>
    /// The amount of dexterity skill points.
    /// </summary>
    [JsonPropertyName("dexterity")]
    public int Dexterity { get; set; }

    /// <summary>
    /// The amount of intelligence skill points.
    /// </summary>
    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }

    /// <summary>
    /// The amount of defence skill points.
    /// </summary>
    [JsonPropertyName("defence")]
    public int Defence { get; set; }

    /// <summary>
    /// The amount of agility skill points.
    /// </summary>
    [JsonPropertyName("agility")]
    public int Agility { get; set; }
}
