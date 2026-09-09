using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Season.Reward;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Guild.Season;

/// <summary>
/// Represents a reward earned by a guild during a season.
/// </summary>
public class GuildSeasonReward
{
    /// <summary>
    /// The condition that must be met to earn this reward.
    /// </summary>
    [JsonPropertyName("condition")]
    public GuildRewardCondition Condition { get; set; } = new();

    /// <summary>
    /// The type of reward.
    /// </summary>
    [JsonPropertyName("type")]
    public EGuildRewardType Type { get; set; }

    /// <summary>
    /// The raw value of the reward. Use ValueAsString() or ValueAsInteger() instead.
    /// </summary>
    [JsonPropertyName("value")]
    [Obsolete("Please use ValueAsString() or ValueAsInteger().")]
    public JsonElement? Value { get; set; }

    /// <summary>
    /// The date and time the reward expires, or null if it does not expire.
    /// </summary>
    [JsonPropertyName("expires")]
    public DateTime? Expires { get; set; }

    /// <summary>
    /// Gets the reward value as a string, or null if not available.
    /// </summary>
    /// <returns>The value as a string, or null.</returns>
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

    /// <summary>
    /// Gets the reward value as an integer, or null if not available.
    /// </summary>
    /// <returns>The value as an integer, or null.</returns>
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