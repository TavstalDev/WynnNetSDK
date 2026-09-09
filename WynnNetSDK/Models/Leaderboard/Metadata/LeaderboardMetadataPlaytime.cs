using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

/// <summary>
/// Represents playtime metadata for a leaderboard entry.
/// </summary>
public class LeaderboardMetadataPlaytime : LeaderboardMetadata
{
    /// <summary>
    /// The total playtime in minutes.
    /// </summary>
    [JsonPropertyName("playtime")]
    public int Playtime { get; set; }
}
