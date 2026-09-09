using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents a player's profession level and experience.
/// </summary>
public class PlayerProfessionInfo
{
    /// <summary>
    /// The current level of the profession.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    /// <summary>
    /// The experience progress percentage to the next level.
    /// </summary>
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }
}