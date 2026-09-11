using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Player.GlobalData;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents detailed information about a single player character including stats and progress.
/// </summary>
public class PlayerDetailedCharacter
{
    /// <summary>
    /// The class type of the character.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    /// <summary>
    /// The reskin applied to the character, or null if none.
    /// </summary>
    [JsonPropertyName("reskin")]
    public string? Reskin { get; set; }

    /// <summary>
    /// The display nickname of the character.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;

    /// <summary>
    /// The current level of the character.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; set; }

    /// <summary>
    /// The current experience points of the character.
    /// </summary>
    [JsonPropertyName("xp")]
    public int Xp { get; set; }

    /// <summary>
    /// The experience progress percentage to the next level.
    /// </summary>
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }

    /// <summary>
    /// The total combined level of the character.
    /// </summary>
    [JsonPropertyName("totalLevel")]
    public int TotalLevel { get; set; }

    /// <summary>
    /// Whether this character was created before the economy update.
    /// </summary>
    [JsonPropertyName("preEconomy")]
    public bool? PreEconomy { get; set; }

    /// <summary>
    /// The list of game modes this character has played in.
    /// </summary>
    [JsonPropertyName("gamemode")]
    public List<string> Gamemode { get; set; } = [];

    /// <summary>
    /// The percentage of game content this character has completed.
    /// </summary>
    [JsonPropertyName("contentCompletion")]
    public int ContentCompletion { get; set; }

    /// <summary>
    /// The number of wars this character has participated in.
    /// </summary>
    [JsonPropertyName("wars")]
    public int Wars { get; set; }

    /// <summary>
    /// The total playtime in hours for this character.
    /// </summary>
    [JsonPropertyName("playtime")]
    public float Playtime { get; set; }

    /// <summary>
    /// The number of mobs killed by this character.
    /// </summary>
    [JsonPropertyName("mobsKilled")]
    public int MobsKilled { get; set; }

    /// <summary>
    /// The number of chests found by this character.
    /// </summary>
    [JsonPropertyName("chestsFound")]
    public int ChestsFound { get; set; }

    /// <summary>
    /// The number of items identified by this character.
    /// </summary>
    [JsonPropertyName("ItemsIdentified")]
    public int ItemsIdentified { get; set; }

    /// <summary>
    /// The number of blocks walked by this character.
    /// </summary>
    [JsonPropertyName("blocksWalked")]
    public int BlocksWalked { get; set; }

    /// <summary>
    /// The number of times this character has logged in.
    /// </summary>
    [JsonPropertyName("logins")]
    public int Logins { get; set; }

    /// <summary>
    /// The number of times this character has died.
    /// </summary>
    [JsonPropertyName("deaths")]
    public int Deaths { get; set; }

    /// <summary>
    /// The number of discoveries made by this character.
    /// </summary>
    [JsonPropertyName("discoveries")]
    public int Discoveries { get; set; }

    /// <summary>
    /// The PvP statistics for this character.
    /// </summary>
    [JsonPropertyName("pvp")]
    public PlayerPvpInfo PvP { get; set; } = new();

    /// <summary>
    /// The allocated skill points for this character.
    /// </summary>
    [JsonPropertyName("skillPoints")]
    public SkillPoints SkillPoints { get; set; } = new();

    /// <summary>
    /// The profession levels and progress for this character.
    /// </summary>
    [JsonPropertyName("professions")]
    public Dictionary<string, PlayerProfessionInfo> Professions { get; set; } = new();

    /// <summary>
    /// The dungeon completion data for this character.
    /// </summary>
    [JsonPropertyName("dungeons")]
    public PlayerDungeons Dungeons { get; set; } = new();

    /// <summary>
    /// The raid completion data for this character.
    /// </summary>
    [JsonPropertyName("raids")]
    public PlayerDungeons Raids { get; set; } = new();

    /// <summary>
    /// The number of world events participated in.
    /// </summary>
    [JsonPropertyName("worldEvents")]
    public int WorldEvents { get; set; }

    /// <summary>
    /// The number of lootruns completed by this character.
    /// </summary>
    [JsonPropertyName("lootruns")]
    public int Lootruns { get; set; }

    /// <summary>
    /// The number of caves explored by this character.
    /// </summary>
    [JsonPropertyName("caves")]
    public int Caves { get; set; }

    /// <summary>
    /// The list of quests completed by this character.
    /// </summary>
    [JsonPropertyName("quests")]
    public List<string> Quests { get; set; } = [];

    /// <summary>
    /// The data access restrictions for this character.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public PlayerDataRestrictions Restrictions { get; set; } = new();

    /// <summary>
    /// The list of stats that have been removed from this character.
    /// </summary>
    [JsonPropertyName("removedStats")]
    public List<string> RemovedStats { get; set; } = [];

    /// <summary>
    /// Additional metadata about the character.
    /// </summary>
    [JsonPropertyName("meta")]
    public PlayerCharacterMeta Meta { get; set; } = new();
}
