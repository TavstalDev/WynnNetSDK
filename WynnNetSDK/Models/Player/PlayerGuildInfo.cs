using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents guild information for a player.
/// </summary>
public class PlayerGuildInfo
{
    /// <summary>
    /// The unique identifier of the guild, or null if none.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// The full name of the guild.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The short prefix of the guild.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;

    /// <summary>
    /// The player's rank within the guild.
    /// </summary>
    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;

    /// <summary>
    /// The star decoration for the player's guild rank.
    /// </summary>
    [JsonPropertyName("rankStars")]
    public string RankStars { get; set; } = string.Empty;
}
