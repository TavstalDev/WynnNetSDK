using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the sub type of an item.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EItemSubType>))]
public enum EItemSubType
{
    /// <summary>
    /// Bow weapon type.
    /// </summary>
    [JsonPropertyName("bow")]
    BOW,

    /// <summary>
    /// Dagger weapon type.
    /// </summary>
    [JsonPropertyName("dagger")]
    DAGGER,

    /// <summary>
    /// Relik weapon type.
    /// </summary>
    [JsonPropertyName("relik")]
    RELIK,

    /// <summary>
    /// Spear weapon type.
    /// </summary>
    [JsonPropertyName("spear")]
    SPEAR,

    /// <summary>
    /// Wand weapon type.
    /// </summary>
    [JsonPropertyName("wand")]
    WAND,

    /// <summary>
    /// Boots armour type.
    /// </summary>
    [JsonPropertyName("boots")]
    BOOTS,

    /// <summary>
    /// Chestplate armour type.
    /// </summary>
    [JsonPropertyName("chestplate")]
    CHESTPLATE,

    /// <summary>
    /// Helmet armour type.
    /// </summary>
    [JsonPropertyName("helmet")]
    HELMET,

    /// <summary>
    /// Leggings armour type.
    /// </summary>
    [JsonPropertyName("leggings")]
    LEGGINGS,

    /// <summary>
    /// Bracelet accessory type.
    /// </summary>
    [JsonPropertyName("bracelet")]
    BRACELET,

    /// <summary>
    /// Necklace accessory type.
    /// </summary>
    [JsonPropertyName("necklace")]
    NECKLACE,

    /// <summary>
    /// Ring accessory type.
    /// </summary>
    [JsonPropertyName("ring")]
    RING,

    /// <summary>
    /// Guild Tome type.
    /// </summary>
    [JsonPropertyName("guildTome")]
    GUILD_TOME,

    /// <summary>
    /// Armour Tome type.
    /// </summary>
    [JsonPropertyName("armourTome")]
    ARMOUR_TOME,

    /// <summary>
    /// Expertise Tome type.
    /// </summary>
    [JsonPropertyName("expertiseTome")]
    EXPERTISE_TOME,

    /// <summary>
    /// Marathon Tome type.
    /// </summary>
    [JsonPropertyName("marathonTome")]
    MARATHON_TOME,

    /// <summary>
    /// Mysticism Tome type.
    /// </summary>
    [JsonPropertyName("mysticismTome")]
    MYSTICISM_TOME,

    /// <summary>
    /// Lootrun Tome type.
    /// </summary>
    [JsonPropertyName("lootrunTome")]
    LOOTRUN_TOME,

    /// <summary>
    /// Weapon Tome type.
    /// </summary>
    [JsonPropertyName("weaponTome")]
    WEAPON_TOME,

    /// <summary>
    /// Axe tool type.
    /// </summary>
    [JsonPropertyName("axe")]
    AXE,

    /// <summary>
    /// Rod tool type.
    /// </summary>
    [JsonPropertyName("rod")]
    ROD,

    /// <summary>
    /// Pickaxe tool type.
    /// </summary>
    [JsonPropertyName("pickaxe")]
    PICKAXE,

    /// <summary>
    /// Scythe tool type.
    /// </summary>
    [JsonPropertyName("scythe")]
    SCYTHE,

    /// <summary>
    /// Farming profession type.
    /// </summary>
    [JsonPropertyName("farming")]
    FARMING,

    /// <summary>
    /// Fishing profession type.
    /// </summary>
    [JsonPropertyName("fishing")]
    FISHING,

    /// <summary>
    /// Mining profession type.
    /// </summary>
    [JsonPropertyName("mining")]
    MINING,

    /// <summary>
    /// Woodcutting profession type.
    /// </summary>
    [JsonPropertyName("woodcutting")]
    WOODCUTTING
}
