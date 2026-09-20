using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

/// <summary>
/// Represents a player's overall raid performance statistics.
/// </summary>
public class PlayerRaidStats
{
    /// <summary>
    /// The total amount of damage taken in raids.
    /// </summary>
    [JsonPropertyName("damageTaken")]
    public ulong DamageTaken { get; set; }

    /// <summary>
    /// The total amount of damage dealt in raids.
    /// </summary>
    [JsonPropertyName("damageDealt")]
    public ulong DamageDealt { get; set; }

    /// <summary>
    /// The total amount of health healed in raids.
    /// </summary>
    [JsonPropertyName("healthHealed")]
    public ulong HealthHealed { get; set; }

    /// <summary>
    /// The total number of deaths in raids.
    /// </summary>
    [JsonPropertyName("deaths")]
    public ulong Deaths { get; set; }

    /// <summary>
    /// The total number of buffs taken in raids.
    /// </summary>
    [JsonPropertyName("buffsTaken")]
    public ulong BuffsTaken { get; set; }

    /// <summary>
    /// The total number of gambits used in raids.
    /// </summary>
    [JsonPropertyName("gambitsUsed")]
    public ulong GambitsUsed { get; set; }
}
