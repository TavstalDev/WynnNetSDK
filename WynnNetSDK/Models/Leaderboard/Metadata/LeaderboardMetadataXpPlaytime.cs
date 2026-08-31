using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

public class LeaderboardMetadataXpPlaytime : LeaderboardMetadata
{
    [JsonPropertyName("xp")]
    public int Xp { get; set; }
    
    [JsonPropertyName("playtime")]
    public int Playtime { get; set; }
}