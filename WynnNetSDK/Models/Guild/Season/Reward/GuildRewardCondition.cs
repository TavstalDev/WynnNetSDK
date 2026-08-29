using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Season.Reward;

public class GuildRewardCondition
{
    [JsonPropertyName("type")]
    public EGuildRewardConditionType Type { get; set; }
    
    [JsonPropertyName("value")]
    public int Value { get; set; }
}