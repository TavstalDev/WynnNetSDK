using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Banner;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;

public class LeaderboardGuildLegacyEntry : LeaderboardEntry
{
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
    
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    [JsonPropertyName("xp")]
    public int Xp { get; set; }
    
    [JsonPropertyName("territories")]
    public int Territories { get; set; }
    
    [JsonPropertyName("wars")]
    public int Wars { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    
    [JsonPropertyName("banner")]
    public GuildBanner Banner { get; set; } = new();
}