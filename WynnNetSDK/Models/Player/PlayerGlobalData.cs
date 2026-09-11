using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Player.GlobalData;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents aggregated global data across all of a player's characters.
/// </summary>
public class PlayerGlobalData
{
    /// <summary>
    /// The percentage of game content the player has completed.
    /// </summary>
    [JsonPropertyName("contentCompletion")]
    public int ContentCompletion { get; set; }

    /// <summary>
    /// The total number of wars the player has participated in.
    /// </summary>
    [JsonPropertyName("wars")]
    public int Wars { get; set; }

    /// <summary>
    /// The combined total level across all characters.
    /// </summary>
    [JsonPropertyName("totalLevel")]
    public int TotalLevel { get; set; }

    /// <summary>
    /// The total number of mobs killed across all characters.
    /// </summary>
    [JsonPropertyName("mobsKilled")]
    public int MobsKilled { get; set; }

    /// <summary>
    /// The total number of chests found across all characters.
    /// </summary>
    [JsonPropertyName("chestsFound")]
    public int ChestsFound { get; set; }

    /// <summary>
    /// The player's dungeon completion statistics.
    /// </summary>
    [JsonPropertyName("dungeons")]
    public PlayerDungeons Dungeons { get; set; } = new();

    /// <summary>
    /// The player's raid completion statistics.
    /// </summary>
    [JsonPropertyName("raids")]
    public PlayerDungeons Raids { get; set; } = new();

    /// <summary>
    /// The total number of world events participated in.
    /// </summary>
    [JsonPropertyName("worldEvents")]
    public int WorldEvents { get; set; }

    /// <summary>
    /// The total number of lootruns completed.
    /// </summary>
    [JsonPropertyName("lootruns")]
    public int Lootruns { get; set; }

    /// <summary>
    /// The total number of caves explored.
    /// </summary>
    [JsonPropertyName("caves")]
    public int Caves { get; set; }

    /// <summary>
    /// The number of quests the player has completed.
    /// </summary>
    [JsonPropertyName("completedQuests")]
    public int CompletedQuests { get; set; }

    /// <summary>
    /// The player's guild raid completion statistics.
    /// </summary>
    [JsonPropertyName("guildRaids")]
    public PlayerDungeons GuildRaids { get; set; } = new();

    /// <summary>
    /// The player's overall raid performance statistics.
    /// </summary>
    [JsonPropertyName("raidStats")]
    public PlayerRaidStats RaidStats { get; set; } = new();

    /// <summary>
    /// The player's PvP kill and death statistics.
    /// </summary>
    [JsonPropertyName("pvp")]
    public PlayerPvpInfo PvP { get; set; } = new();
}
