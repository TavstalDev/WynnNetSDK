using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;

/// <summary>
/// Represents total level, experience, and playtime metadata for a leaderboard entry.
/// </summary>
public class LeaderboardMetadataTotalLevelXpPlaytime : LeaderboardMetadata
{
    /// <summary>
    /// The total combined level across all characters.
    /// </summary>
    [JsonPropertyName("totalLevel")]
    public ulong TotalLevel { get; set; }

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
