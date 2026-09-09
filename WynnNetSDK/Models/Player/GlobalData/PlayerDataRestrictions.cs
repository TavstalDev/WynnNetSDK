using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

/// <summary>
/// Represents data access restrictions for a player.
/// </summary>
public class PlayerDataRestrictions
{
    /// <summary>
    /// Whether the player's main profile data is accessible.
    /// </summary>
    [JsonPropertyName("mainAccess")]
    public bool MainAccess { get; set; }
    
    /// <summary>
    /// Whether the player's character data is accessible.
    /// </summary>
    [JsonPropertyName("characterDataAccess")]
    public bool CharacterDataAccess { get; set; }
}