using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Banner;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;

/// <summary>
/// Represents a guild entry on the leaderboard.
/// </summary>
public class LeaderboardGuildEntry : LeaderboardEntry
{
    /// <summary>
    /// The meta score of the guild.
    /// </summary>
    [JsonPropertyName("metaScore")]
    public int MetaScore { get; set; }

    /// <summary>
    /// The tag or prefix of the guild.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;

    /// <summary>
    /// The score of the guild.
    /// </summary>
    [JsonPropertyName("score")]
    public double Score { get; set; }

    /// <summary>
    /// The metadata associated with this guild entry.
    /// </summary>
    [JsonPropertyName("metadata")]
    [JsonConverter(typeof(LeaderboardMetadataDeserializer))]
    public LeaderboardMetadata? Metadata { get; set; }

    /// <summary>
    /// The banner of the guild.
    /// </summary>
    [JsonPropertyName("banner")]
    public GuildBanner Banner { get; set; } = new();

    /// <summary>
    /// The previous ranking of the guild.
    /// </summary>
    [JsonPropertyName("previousRanking")]
    public int? PreviousRanking { get; set; }
}
