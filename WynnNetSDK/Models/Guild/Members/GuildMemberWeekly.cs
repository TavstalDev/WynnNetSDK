using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

/// <summary>
/// Represents a guild member's weekly activity data.
/// </summary>
public class GuildMemberWeekly
{
    /// <summary>
    /// Whether the member completed their weekly objectives.
    /// </summary>
    [JsonPropertyName("completed")]
    public bool Completed { get; set; }

    /// <summary>
    /// The number of consecutive weeks the member has completed objectives.
    /// </summary>
    [JsonPropertyName("streak")]
    public int Streak { get; set; }
}