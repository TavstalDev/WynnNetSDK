using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.News.Enums;

public enum EPollRequirementSubType
{
    [JsonPropertyName("combat")]
    COMBAT,
    [JsonPropertyName("alchemism")]
    ALCHEMISM,
    [JsonPropertyName("armouring")]
    ARMOURING,
    [JsonPropertyName("cooking")]
    COOKING,
    [JsonPropertyName("farming")]
    FARMING,
    [JsonPropertyName("fishing")]
    FISHING,
    [JsonPropertyName("jeweling")]
    JEWELING,
    [JsonPropertyName("mining")]
    MINING,
    [JsonPropertyName("scribing")]
    SCRIBING,
    [JsonPropertyName("tailoring")]
    TAILORING,
    [JsonPropertyName("weaponsmithing")]
    WEAPONSMITHING,
    [JsonPropertyName("woodcutting")]
    WOODCUTTING,
    [JsonPropertyName("woodworking")]
    WOODWORKING,
    [JsonPropertyName("orphion")]
    ORPHION,
    [JsonPropertyName("fruma")]
    FRUMA,
    [JsonPropertyName("colossus")]
    COLOSSUS,
    [JsonPropertyName("grootslang")]
    GROOTSLANG,
    [JsonPropertyName("nameless")]
    NAMELESS,
    [JsonPropertyName("orphion_guild")]
    ORPHION_GUILD,
    [JsonPropertyName("fruma_guild")]
    FRUMA_GUILD,
    [JsonPropertyName("colossus_guild")]
    COLOSSUS_GUILD,
    [JsonPropertyName("grootslang_guild")]
    GROOTSLANG_GUILD,
    [JsonPropertyName("nameless_guild")]
    NAMELESS_GUILD
}
