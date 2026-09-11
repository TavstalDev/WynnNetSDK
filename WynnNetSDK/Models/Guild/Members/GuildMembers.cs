using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

/// <summary>
/// Represents all members of a guild grouped by rank.
/// </summary>
public class GuildMembers
{
    /// <summary>
    /// The total number of members in the guild.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }

    /// <summary>
    /// The members with the Owner rank.
    /// </summary>
    [JsonPropertyName("owner")]
    public Dictionary<string, GuildMember> Owner { get; set; } = [];

    /// <summary>
    /// The members with the Chief rank.
    /// </summary>
    [JsonPropertyName("chief")]
    public Dictionary<string, GuildMember> Chief { get; set; } = [];

    /// <summary>
    /// The members with the Strategist rank.
    /// </summary>
    [JsonPropertyName("strategist")]
    public Dictionary<string, GuildMember> Strategist { get; set; } = [];

    /// <summary>
    /// The members with the Recruiter rank.
    /// </summary>
    [JsonPropertyName("recruiter")]
    public Dictionary<string, GuildMember> Recruiter { get; set; } = [];

    /// <summary>
    /// The members with the Recruit rank.
    /// </summary>
    [JsonPropertyName("recruit")]
    public Dictionary<string, GuildMember> Recruit { get; set; } = [];
}
