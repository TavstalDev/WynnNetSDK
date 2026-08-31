using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

public class LeaderboardMetadataCompletionsGambits : LeaderboardMetadata
{
    [JsonPropertyName("completions")]
    public int Completions { get; set; }
    
    [JsonPropertyName("gambits")]
    public int Gambits { get; set; }
}