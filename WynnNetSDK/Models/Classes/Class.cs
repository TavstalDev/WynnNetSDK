using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

/// <summary>
/// Represents a player character class in Wynncraft.
/// </summary>
public class Class
{
    /// <summary>
    /// The display name of the class.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The overall difficulty rating of the class.
    /// </summary>
    [JsonPropertyName("overallDifficulty")]
    public int OverallDifficultx { get; set; }
}
