using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

public class LeaderboardMetadataSeason : LeaderboardMetadata
{
    [JsonPropertyName("seasonName")]
    public string SeasonName { get; set; } = string.Empty;
    
    [JsonPropertyName("position")]
    public int Position { get; set; }
}