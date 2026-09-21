using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Guild.Season.Reward;

/// <summary>
/// Represents the type of condition for a guild season reward.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EGuildRewardConditionType>))]
public enum EGuildRewardConditionType
{
    /// <summary>
    /// Condition based on season rating.
    /// </summary>
    SR = 0,

    /// <summary>
    /// Condition based on leaderboard position.
    /// </summary>
    LEADERBOARD_POSITION = 1
}
