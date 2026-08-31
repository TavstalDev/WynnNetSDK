using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Season.Reward;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Guild.Season;

public class GuildSeasonReward
{
    [JsonPropertyName("condition")]
    public GuildRewardCondition Condition { get; set; } = new();
    
    [JsonPropertyName("type")]
    public EGuildRewardType Type { get; set; }
    
    [JsonPropertyName("value")]
    [Obsolete("Please use ValueAsString() or ValueAsInteger().")]
    public JsonElement? Value { get; set; }
    
    [JsonPropertyName("expires")]
    public DateTime? Expires { get; set; }

    public string? ValueAsString()
    {
        if (Value == null || !Value.HasValue)
            return null;

        var v = Value.Value;
        switch (v.ValueKind)
        {
            case JsonValueKind.String:
                return v.GetString();
            case JsonValueKind.Number:
                return v.GetRawText();
        }
        return null;
    }

    public int? ValueAsInteger()
    {
        if (Value == null || !Value.HasValue)
            return null;

        var v = Value.Value;
        switch (v.ValueKind)
        {
            case JsonValueKind.Number:
                return v.GetInt32();
        }
        return null;
    }
}