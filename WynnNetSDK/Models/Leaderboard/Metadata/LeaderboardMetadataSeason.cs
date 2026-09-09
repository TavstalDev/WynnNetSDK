using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

/// <summary>
/// Represents season-related metadata for a leaderboard entry.
/// </summary>
public class LeaderboardMetadataSeason : LeaderboardMetadata
{
    /// <summary>
    /// The name of the season.
    /// </summary>
    [JsonPropertyName("seasonName")]
    public string SeasonName { get; set; } = string.Empty;

    /// <summary>
    /// The position within the season.
    /// </summary>
    [JsonPropertyName("position")]
    public int Position { get; set; }
}
