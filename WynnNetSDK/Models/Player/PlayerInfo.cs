using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerInfo
{
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;
    
    [JsonPropertyName("online")]
    public bool Online { get; set; }
    
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;
    
    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;
    
    [JsonPropertyName("supportRank")]
    public string SupportRank { get; set; } = string.Empty;
    
    [JsonPropertyName("shortenedRank")]
    public string ShortenedRank { get; set; } = string.Empty;
    
    [JsonPropertyName("legacyRankColour")]
    public Dictionary<string, string> LegacyRankColour { get; set; } = new();
    
    [JsonPropertyName("rankBadge")]
    public string RankBadge { get; set; } = string.Empty;
}