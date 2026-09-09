using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents basic public information about a player.
/// </summary>
public class PlayerInfo
{
    /// <summary>
    /// The player's username.
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;
    
    /// <summary>
    /// Whether the player is currently online.
    /// </summary>
    [JsonPropertyName("online")]
    public bool Online { get; set; }
    
    /// <summary>
    /// The player's display nickname.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;
    
    /// <summary>
    /// The player's rank title.
    /// </summary>
    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;
    
    /// <summary>
    /// The player's support tier rank.
    /// </summary>
    [JsonPropertyName("supportRank")]
    public string SupportRank { get; set; } = string.Empty;
    
    /// <summary>
    /// The shortened version of the player's rank.
    /// </summary>
    [JsonPropertyName("shortenedRank")]
    public string ShortenedRank { get; set; } = string.Empty;
    
    /// <summary>
    /// The legacy color data for the player's rank display.
    /// </summary>
    [JsonPropertyName("legacyRankColour")]
    public Dictionary<string, string> LegacyRankColour { get; set; } = new();
    
    /// <summary>
    /// The badge icon associated with the player's rank.
    /// </summary>
    [JsonPropertyName("rankBadge")]
    public string RankBadge { get; set; } = string.Empty;
}