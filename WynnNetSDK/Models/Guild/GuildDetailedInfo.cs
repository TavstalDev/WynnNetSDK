using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Banner;
using Tavstal.WynnNetSDK.Models.Guild.Members;
using Tavstal.WynnNetSDK.Models.Guild.Season;

namespace Tavstal.WynnNetSDK.Models.Guild;

/// <summary>
/// Represents detailed information about a guild.
/// </summary>
public class GuildDetailedInfo
{
    /// <summary>
    /// The name of the guild.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The UUID of the guild.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

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
    /// The experience progress to the next level as a percentage.
    /// </summary>
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }

    /// <summary>
    /// The number of territories held by the guild.
    /// </summary>
    [JsonPropertyName("territories")]
    public int Territories { get; set; }

    /// <summary>
    /// The number of wars the guild has won.
    /// </summary>
    [JsonPropertyName("wars")]
    public int Wars { get; set; }

    /// <summary>
    /// The number of raids the guild has completed.
    /// </summary>
    [JsonPropertyName("raids")]
    public int Raids { get; set; }

    /// <summary>
    /// The date and time the guild was created.
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    /// <summary>
    /// The members of the guild grouped by rank.
    /// </summary>
    [JsonPropertyName("members")]
    public GuildMembers Members { get; set; } = new();

    /// <summary>
    /// The number of members currently online.
    /// </summary>
    [JsonPropertyName("online")]
    public int Online { get; set; }

    /// <summary>
    /// The banner design of the guild.
    /// </summary>
    [JsonPropertyName("banner")]
    public GuildBanner Banner { get; set; } = new();

    /// <summary>
    /// The guild's season ranks keyed by season identifier.
    /// </summary>
    [JsonPropertyName("seasonRanks")]
    public Dictionary<string, GuildSeasonRank> SeasonRanks { get; set; } = [];

    /// <summary>
    /// The guild's ranking information, or null if not available.
    /// </summary>
    [JsonPropertyName("ranking")]
    public GuildRanking? Ranking { get; set; }
}
