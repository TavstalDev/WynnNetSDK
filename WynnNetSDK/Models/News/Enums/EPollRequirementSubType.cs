using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.News.Enums;

/// <summary>
/// The sub type of a poll requirement, such as a profession or raid.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EPollRequirementSubType>))]
public enum EPollRequirementSubType
{
    /// <summary>
    /// The combat profession.
    /// </summary>
    [JsonPropertyName("combat")]
    COMBAT,
    /// <summary>
    /// The alchemism profession.
    /// </summary>
    [JsonPropertyName("alchemism")]
    ALCHEMISM,
    /// <summary>
    /// The armouring profession.
    /// </summary>
    [JsonPropertyName("armouring")]
    ARMOURING,
    /// <summary>
    /// The cooking profession.
    /// </summary>
    [JsonPropertyName("cooking")]
    COOKING,
    /// <summary>
    /// The farming profession.
    /// </summary>
    [JsonPropertyName("farming")]
    FARMING,
    /// <summary>
    /// The fishing profession.
    /// </summary>
    [JsonPropertyName("fishing")]
    FISHING,
    /// <summary>
    /// The jeweling profession.
    /// </summary>
    [JsonPropertyName("jeweling")]
    JEWELING,
    /// <summary>
    /// The mining profession.
    /// </summary>
    [JsonPropertyName("mining")]
    MINING,
    /// <summary>
    /// The scribing profession.
    /// </summary>
    [JsonPropertyName("scribing")]
    SCRIBING,
    /// <summary>
    /// The tailoring profession.
    /// </summary>
    [JsonPropertyName("tailoring")]
    TAILORING,
    /// <summary>
    /// The weaponsmithing profession.
    /// </summary>
    [JsonPropertyName("weaponsmithing")]
    WEAPONSMITHING,
    /// <summary>
    /// The woodcutting profession.
    /// </summary>
    [JsonPropertyName("woodcutting")]
    WOODCUTTING,
    /// <summary>
    /// The woodworking profession.
    /// </summary>
    [JsonPropertyName("woodworking")]
    WOODWORKING,
    /// <summary>
    /// The Orphion raid.
    /// </summary>
    [JsonPropertyName("orphion")]
    ORPHION,
    /// <summary>
    /// The Fruma raid.
    /// </summary>
    [JsonPropertyName("fruma")]
    FRUMA,
    /// <summary>
    /// The Colossus raid.
    /// </summary>
    [JsonPropertyName("colossus")]
    COLOSSUS,
    /// <summary>
    /// The Grootslang raid.
    /// </summary>
    [JsonPropertyName("grootslang")]
    GROOTSLANG,
    /// <summary>
    /// The Nameless raid.
    /// </summary>
    [JsonPropertyName("nameless")]
    NAMELESS,
    /// <summary>
    /// The Orphion guild raid.
    /// </summary>
    [JsonPropertyName("orphion_guild")]
    ORPHION_GUILD,
    /// <summary>
    /// The Fruma guild raid.
    /// </summary>
    [JsonPropertyName("fruma_guild")]
    FRUMA_GUILD,
    /// <summary>
    /// The Colossus guild raid.
    /// </summary>
    [JsonPropertyName("colossus_guild")]
    COLOSSUS_GUILD,
    /// <summary>
    /// The Grootslang guild raid.
    /// </summary>
    [JsonPropertyName("grootslang_guild")]
    GROOTSLANG_GUILD,
    /// <summary>
    /// The Nameless guild raid.
    /// </summary>
    [JsonPropertyName("nameless_guild")]
    NAMELESS_GUILD
}
