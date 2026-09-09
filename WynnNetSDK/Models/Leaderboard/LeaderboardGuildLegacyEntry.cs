using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Banner;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;

/// <summary>
/// Represents a legacy guild entry on the leaderboard.
/// </summary>
public class LeaderboardGuildLegacyEntry : LeaderboardEntry
{
    /// <summary>
    /// The tag or prefix of the guild.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;

    /// <summary>
    /// The level of the guild.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }

    /// <summary>
    /// The experience points of the guild.
    /// </summary>
    [JsonPropertyName("xp")]
    public int Xp { get; set; }

    /// <summary>
    /// The number of territories controlled by the guild.
    /// </summary>
    [JsonPropertyName("territories")]
    public int Territories { get; set; }

    /// <summary>
    /// The number of wars won by the guild.
    /// </summary>
    [JsonPropertyName("wars")]
    public int Wars { get; set; }

    /// <summary>
    /// The date and time the guild was created.
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    /// <summary>
    /// The banner of the guild.
    /// </summary>
    [JsonPropertyName("banner")]
    public GuildBanner Banner { get; set; } = new();
}
