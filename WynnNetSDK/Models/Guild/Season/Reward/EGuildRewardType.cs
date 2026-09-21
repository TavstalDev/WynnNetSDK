using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Guild.Season.Reward;

/// <summary>
/// Represents the type of reward a guild can earn in a season.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EGuildRewardType>))]
public enum EGuildRewardType
{
    /// <summary>
    /// A badge reward.
    /// </summary>
    BADGE = 0,

    /// <summary>
    /// An effect reward.
    /// </summary>
    EFFECT = 1,

    /// <summary>
    /// A cosmetic reward.
    /// </summary>
    COSMETIC = 2,

    /// <summary>
    /// An emerald reward.
    /// </summary>
    EMERALD = 3,

    /// <summary>
    /// A private bank slot reward.
    /// </summary>
    PRIVATE_BANK_SLOT = 4,

    /// <summary>
    /// A public bank slot reward.
    /// </summary>
    PUBLIC_BANK_SLOT = 5,

    /// <summary>
    /// A guild tome reward.
    /// </summary>
    GUILD_TOME = 6,

    /// <summary>
    /// A structure reward.
    /// </summary>
    STRUCTURE = 7
}
