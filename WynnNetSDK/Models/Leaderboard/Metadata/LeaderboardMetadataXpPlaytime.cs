using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

/// <summary>
/// Represents experience and playtime metadata for a leaderboard entry.
/// </summary>
public class LeaderboardMetadataXpPlaytime : LeaderboardMetadata
{
    /// <summary>
    /// The experience points earned.
    /// </summary>
    [JsonPropertyName("xp")]
    public ulong Xp { get; set; }

    /// <summary>
    /// The total playtime in minutes.
    /// </summary>
    [JsonPropertyName("playtime")]
    public double Playtime { get; set; }
}
