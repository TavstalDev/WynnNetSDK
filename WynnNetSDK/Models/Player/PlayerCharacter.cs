using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents basic information about a player character.
/// </summary>
public class PlayerCharacter
{
    /// <summary>
    /// The class type of the character.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// The reskin applied to the character, or null if none.
    /// </summary>
    [JsonPropertyName("reskin")]
    public string? Reskin { get; set; }

    /// <summary>
    /// The display nickname of the character.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;

    /// <summary>
    /// The current level of the character.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }

    /// <summary>
    /// The current experience points of the character.
    /// </summary>
    [JsonPropertyName("xp")]
    public int Xp { get; set; }

    /// <summary>
    /// The experience progress percentage to the next level.
    /// </summary>
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }

    /// <summary>
    /// The total combined level of the character.
    /// </summary>
    [JsonPropertyName("totalLevel")]
    public int TotalLevel { get; set; }

    /// <summary>
    /// The list of game modes this character has played in.
    /// </summary>
    [JsonPropertyName("gamemode")]
    public List<string> Gamemode { get; set; } = [];

    /// <summary>
    /// Additional metadata about the character.
    /// </summary>
    [JsonPropertyName("meta")]
    public PlayerCharacterMeta Meta { get; set; } = new();
}
