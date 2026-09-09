using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Enums;

/// <summary>
/// Represents the item set that an item belongs to.
/// </summary>
public enum EItemSet
{
    /// <summary>
    /// Boundless set.
    /// </summary>
    [JsonPropertyName("boundless")]
    BOUNDLESS,

    /// <summary>
    /// Corrupted set.
    /// </summary>
    [JsonPropertyName("corrupted")]
    CORRUPTED,

    /// <summary>
    /// Firemoss set.
    /// </summary>
    [JsonPropertyName("firemoss")]
    FIREMOSS,

    /// <summary>
    /// Bony set.
    /// </summary>
    [JsonPropertyName("bony")]
    BONY,

    /// <summary>
    /// Spore set.
    /// </summary>
    [JsonPropertyName("spore")]
    SPORE,

    /// <summary>
    /// Petal set.
    /// </summary>
    [JsonPropertyName("petal")]
    PETAL,

    /// <summary>
    /// Scrap set.
    /// </summary>
    [JsonPropertyName("scrap")]
    SCRAP,

    /// <summary>
    /// Beachside set.
    /// </summary>
    [JsonPropertyName("beachside")]
    BEACHSIDE,

    /// <summary>
    /// Pigman set.
    /// </summary>
    [JsonPropertyName("pigman")]
    PIGMAN,

    /// <summary>
    /// Toxic set.
    /// </summary>
    [JsonPropertyName("toxic")]
    TOXIC,

    /// <summary>
    /// Regal set.
    /// </summary>
    [JsonPropertyName("regal")]
    REGAL,

    /// <summary>
    /// Vexing set.
    /// </summary>
    [JsonPropertyName("vexing")]
    VEXING,

    /// <summary>
    /// Voidglass set.
    /// </summary>
    [JsonPropertyName("voidglass")]
    VOIDGLASS,

    /// <summary>
    /// Cosmic Foundations set.
    /// </summary>
    [JsonPropertyName("cosmicFoundations")]
    COSMIC_FOUNDATIONS,

    /// <summary>
    /// Snail set.
    /// </summary>
    [JsonPropertyName("snail")]
    SNAIL,

    /// <summary>
    /// Thanos Legionnaire set.
    /// </summary>
    [JsonPropertyName("thanosLegionnaire")]
    THANOS_LEGIONNAIRE,

    /// <summary>
    /// Uth set.
    /// </summary>
    [JsonPropertyName("uth")]
    UTH,

    /// <summary>
    /// Cosmic set.
    /// </summary>
    [JsonPropertyName("cosmic")]
    COSMIC,

    /// <summary>
    /// Leaf set.
    /// </summary>
    [JsonPropertyName("leaf")]
    LEAF,

    /// <summary>
    /// Tribal set.
    /// </summary>
    [JsonPropertyName("tribal")]
    TRIBAL,

    /// <summary>
    /// Saint's set.
    /// </summary>
    [JsonPropertyName("saint's")]
    SAINTS,

    /// <summary>
    /// Visceral set.
    /// </summary>
    [JsonPropertyName("visceral")]
    VISCERAL,

    /// <summary>
    /// Ascension set.
    /// </summary>
    [JsonPropertyName("ascension")]
    ASCENSION,

    /// <summary>
    /// Ultramarine set.
    /// </summary>
    [JsonPropertyName("ultramarine")]
    ULTRAMARINE,

    /// <summary>
    /// Taiga Elk set.
    /// </summary>
    [JsonPropertyName("taigaElk")]
    TAIGA_ELK,

    /// <summary>
    /// Clock set.
    /// </summary>
    [JsonPropertyName("clock")]
    CLOCK,

    /// <summary>
    /// Nii set.
    /// </summary>
    [JsonPropertyName("nii")]
    NII,

    /// <summary>
    /// Moirai set.
    /// </summary>
    [JsonPropertyName("moirai")]
    MOIRAI,

    /// <summary>
    /// Bleeding set.
    /// </summary>
    [JsonPropertyName("bleeding")]
    BLEEDING,

    /// <summary>
    /// Liffmail set.
    /// </summary>
    [JsonPropertyName("liffmail")]
    LIFFMAIL,

    /// <summary>
    /// Elf set.
    /// </summary>
    [JsonPropertyName("elf")]
    ELF,

    /// <summary>
    /// Slime set.
    /// </summary>
    [JsonPropertyName("slime")]
    SLIME,

    /// <summary>
    /// Goblin set.
    /// </summary>
    [JsonPropertyName("goblin")]
    GOBLIN,

    /// <summary>
    /// Ghostly set.
    /// </summary>
    [JsonPropertyName("ghostly")]
    GHOSTLY,

    /// <summary>
    /// Horse set.
    /// </summary>
    [JsonPropertyName("horse")]
    HORSE,

    /// <summary>
    /// Snow set.
    /// </summary>
    [JsonPropertyName("snow")]
    SNOW,

    /// <summary>
    /// Skien's set.
    /// </summary>
    [JsonPropertyName("skien's")]
    SKIENS,

    /// <summary>
    /// Thunder Relic set.
    /// </summary>
    [JsonPropertyName("thunderRelic")]
    THUNDER_RELIC,

    /// <summary>
    /// Morph set.
    /// </summary>
    [JsonPropertyName("morph")]
    MORPH,

    /// <summary>
    /// Black set.
    /// </summary>
    [JsonPropertyName("black")]
    BLACK,

    /// <summary>
    /// Earth Relic set.
    /// </summary>
    [JsonPropertyName("earthRelic")]
    EARTH_RELIC,

    /// <summary>
    /// Water Relic set.
    /// </summary>
    [JsonPropertyName("waterRelic")]
    WATER_RELIC,

    /// <summary>
    /// Relic set.
    /// </summary>
    [JsonPropertyName("relic")]
    RELIC,

    /// <summary>
    /// Outlaw set.
    /// </summary>
    [JsonPropertyName("outlaw")]
    OUTLAW,

    /// <summary>
    /// Silverfish set.
    /// </summary>
    [JsonPropertyName("silverfish")]
    SILVERFISH,

    /// <summary>
    /// Nether set.
    /// </summary>
    [JsonPropertyName("nether")]
    NETHER,

    /// <summary>
    /// Fire Relic set.
    /// </summary>
    [JsonPropertyName("fireRelic")]
    FIRE_RELIC,

    /// <summary>
    /// Air Relic set.
    /// </summary>
    [JsonPropertyName("airRelic")]
    AIR_RELIC,

    /// <summary>
    /// Adventurer set.
    /// </summary>
    [JsonPropertyName("adventurer")]
    ADVENTURER,

    /// <summary>
    /// Darkened set.
    /// </summary>
    [JsonPropertyName("darkened")]
    DARKENED,

    /// <summary>
    /// Bovine set.
    /// </summary>
    [JsonPropertyName("bovine")]
    BOVINE,

    /// <summary>
    /// Bear set.
    /// </summary>
    [JsonPropertyName("bear")]
    BEAR,

    /// <summary>
    /// Kaerynn set.
    /// </summary>
    [JsonPropertyName("kaerynn")]
    KAERYNN,

    /// <summary>
    /// Villager set.
    /// </summary>
    [JsonPropertyName("villager")]
    VILLAGER,

    /// <summary>
    /// Spider set.
    /// </summary>
    [JsonPropertyName("spider")]
    SPIDER,

    /// <summary>
    /// Conquered Skies set.
    /// </summary>
    [JsonPropertyName("conqueredSkies")]
    CONQUERED_SKIES,

    /// <summary>
    /// Synch Core set.
    /// </summary>
    [JsonPropertyName("synchCore")]
    SYNCH_CORE,

    /// <summary>
    /// Flashfire set.
    /// </summary>
    [JsonPropertyName("flashfire")]
    FLASHFIRE,

    /// <summary>
    /// Jester set.
    /// </summary>
    [JsonPropertyName("jester")]
    JESTER,

    /// <summary>
    /// Forgotten Chronicles set.
    /// </summary>
    [JsonPropertyName("forgottenChronicles")]
    FORGOTTEN_CHRONICLES,

    /// <summary>
    /// Wynnterfest 2016 set.
    /// </summary>
    [JsonPropertyName("wynnterfest2016")]
    WYNTERFEST2016,

    /// <summary>
    /// Bandit's set.
    /// </summary>
    [JsonPropertyName("bandit's")]
    BANDITS,

    /// <summary>
    /// Desert set.
    /// </summary>
    [JsonPropertyName("desert")]
    DESERT,

    /// <summary>
    /// Black Catalyst set.
    /// </summary>
    [JsonPropertyName("blackCatalyst")]
    BLACK_CATALYST,

    /// <summary>
    /// Constellation set.
    /// </summary>
    [JsonPropertyName("constellation")]
    CONSTELLATION,

    /// <summary>
    /// Hallowynn 2016 set.
    /// </summary>
    [JsonPropertyName("hallowynn2016")]
    HALLOWYNN2016
}
