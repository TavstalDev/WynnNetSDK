using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

/// <summary>
/// Represents a player's PvP combat statistics.
/// </summary>
public class PlayerPvpInfo
{
    /// <summary>
    /// The total number of PvP kills.
    /// </summary>
    [JsonPropertyName("kills")]
    public int Kills { get; set; }
    
    /// <summary>
    /// The total number of PvP deaths.
    /// </summary>
    [JsonPropertyName("deaths")]
    public int Deaths { get; set; }
}