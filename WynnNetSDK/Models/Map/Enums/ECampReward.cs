using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Map.Enums;

/// <summary>
/// The type of reward given by a camp.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<ECampReward>))]
public enum ECampReward
{
    /// <summary>
    /// An aspect reward.
    /// </summary>
    ASPECT,
    /// <summary>
    /// A currency reward.
    /// </summary>
    CURRENCY,
    /// <summary>
    /// An ingredient reward.
    /// </summary>
    INGREDIENT,
    /// <summary>
    /// An item reward.
    /// </summary>
    ITEM,
    /// <summary>
    /// A tome reward.
    /// </summary>
    TOME,
    /// <summary>
    /// A ward reward.
    /// </summary>
    WARD
}
