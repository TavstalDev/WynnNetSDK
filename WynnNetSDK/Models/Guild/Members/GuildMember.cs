using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

/// <summary>
/// Represents a member of a guild.
/// </summary>
public class GuildMember
{
    /// <summary>
    /// The UUID of the member.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    /// The username of the member.
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Whether the member is currently online.
    /// </summary>
    [JsonPropertyName("online")]
    public bool Online { get; set; }

    /// <summary>
    /// The date and time the member last joined the game.
    /// </summary>
    [JsonPropertyName("lastJoin")]
    public DateTime? LastJoin { get; set; }

    /// <summary>
    /// The server the member is currently on, or null if offline.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The total amount of resources contributed to the guild.
    /// </summary>
    [JsonPropertyName("contributed")]
    public int Contributed { get; set; }

    /// <summary>
    /// The member's rank in terms of contributions.
    /// </summary>
    [JsonPropertyName("contributionRank")]
    public int ContributionRank { get; set; }

    /// <summary>
    /// The date and time the member joined the guild.
    /// </summary>
    [JsonPropertyName("joined")]
    public DateTime Joined { get; set; }

    /// <summary>
    /// The member's weekly activity data.
    /// </summary>
    [JsonPropertyName("weekly")]
    public GuildMemberWeekly Weekly { get; set; } = new();

    /// <summary>
    /// The member's global statistics across all characters.
    /// </summary>
    [JsonPropertyName("globalData")]
    public GuildMemberGlobalData GlobalData { get; set; } = new();

    /// <summary>
    /// The data visibility restrictions for this member.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public GuildMemberDataRestrictions Restrictions { get; set; } = new();
}
