using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents metadata for a player character.
/// </summary>
public class PlayerCharacterMeta
{
    /// <summary>
    /// Whether the character has died, or null if unknown.
    /// </summary>
    [JsonPropertyName("died")]
    public bool? Died { get; set; }
}