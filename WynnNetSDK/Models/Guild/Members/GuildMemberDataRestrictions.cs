using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

/// <summary>
/// Represents the data visibility restrictions for a guild member.
/// </summary>
public class GuildMemberDataRestrictions
{
    /// <summary>
    /// Whether the member's online status is visible.
    /// </summary>
    [JsonPropertyName("online_status")]
    public bool OnlineStatus { get; set; }

    /// <summary>
    /// Whether the member's main data is accessible.
    /// </summary>
    [JsonPropertyName("main_access")]
    public bool MainAccess { get; set; }

    /// <summary>
    /// Whether the member's data is accessible to high-ranked guild members.
    /// </summary>
    [JsonPropertyName("guild_high_ranked_access")]
    public bool GuildHighRankedAccess { get; set; }
}