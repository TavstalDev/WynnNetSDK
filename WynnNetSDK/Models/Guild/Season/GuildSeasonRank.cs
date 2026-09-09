using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Season;

/// <summary>
/// Represents a guild's rank in a specific season.
/// </summary>
public class GuildSeasonRank
{
    /// <summary>
    /// The season rating of the guild.
    /// </summary>
    [JsonPropertyName("rating")]
    public int Rating { get; set; }

    /// <summary>
    /// The number of territories held at the end of the season.
    /// </summary>
    [JsonPropertyName("finalTerritories")]
    public int FinalTerritories { get; set; }
}