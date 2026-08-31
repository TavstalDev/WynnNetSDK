using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

public class LeaderboardMetadataPlaytime : LeaderboardMetadata
{
    [JsonPropertyName("playtime")]
    public int Playtime { get; set; }
}