using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Season.Reward;

/// <summary>
/// Represents the condition that must be met to earn a guild season reward.
/// </summary>
public class GuildRewardCondition
{
    /// <summary>
    /// The type of condition required.
    /// </summary>
    [JsonPropertyName("type")]
    public EGuildRewardConditionType Type { get; set; }

    /// <summary>
    /// The value associated with the condition.
    /// </summary>
    [JsonPropertyName("value")]
    public int Value { get; set; }
}
