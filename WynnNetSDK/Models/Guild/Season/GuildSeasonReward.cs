using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Season.Reward;

namespace Tavstal.WynnNetSDK.Models.Guild.Season;

public class GuildSeasonReward
{
    [JsonPropertyName("condition")]
    public GuildRewardCondition Condition { get; set; } = new();
    
    [JsonPropertyName("type")]
    public EGuildRewardType Type { get; set; }
    
    [JsonPropertyName("value")]
    public object? Value { get; set; }
    
    [JsonPropertyName("expires")]
    public DateTime? Expires { get; set; }

    public void GetValue(out int? intValue, out string? stringValue)
    {
        if (Value is string str)
        {
            intValue = null;
            stringValue = str;
            return;
        }

        if (Value is int @int)
        {
            intValue = @int;
            stringValue = null;
            return;
        }

        throw new Exception("Invalid value.");
    }
}