using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

/// <summary>
/// Represents completions and gambits metadata for a leaderboard entry.
/// </summary>
public class LeaderboardMetadataCompletionsGambits : LeaderboardMetadata
{
    /// <summary>
    /// The number of completions.
    /// </summary>
    [JsonPropertyName("completions")]
    public ulong Completions { get; set; }

    /// <summary>
    /// The number of gambits earned.
    /// </summary>
    [JsonPropertyName("gambits")]
    public ulong Gambits { get; set; }
}
