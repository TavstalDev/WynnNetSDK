using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

public class LeaderboardMetadataTotalLevelXpPlaytime : LeaderboardMetadata
{
    [JsonPropertyName("totalLevel")]
    public int TotalLevel { get; set; }
    
    [JsonPropertyName("xp")]
    public int Xp { get; set; }
    
    [JsonPropertyName("playtime")]
    public int Playtime { get; set; }
}