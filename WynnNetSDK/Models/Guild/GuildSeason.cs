using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Season;

namespace Tavstal.WynnNetSDK.Models.Guild;

/// <summary>
/// Represents information about a guild season.
/// </summary>
public class GuildSeason
{
    /// <summary>
    /// The season rating earned per hour of territory holding.
    /// </summary>
    [JsonPropertyName("territoryHoldingSrPerHour")]
    public int TerritoryHoldingSrPerHour { get; set; }

    /// <summary>
    /// The season rating earned per war.
    /// </summary>
    [JsonPropertyName("srPerWar")]
    public int SrPerWar { get; set; }

    /// <summary>
    /// The list of rewards based on season rating.
    /// </summary>
    [JsonPropertyName("ratingRewards")]
    public List<GuildSeasonReward> RatingRewards { get; set; } = [];

    /// <summary>
    /// The list of rewards based on leaderboard position.
    /// </summary>
    [JsonPropertyName("leaderboardRewards")]
    public List<GuildSeasonReward> LeaderboardRewards { get; set; } = [];

    /// <summary>
    /// The date and time the season started, or null if not available.
    /// </summary>
    [JsonPropertyName("initDate")]
    public DateTime? InitDate { get; set; }

    /// <summary>
    /// The date and time the season ends, or null if not available.
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }
}
