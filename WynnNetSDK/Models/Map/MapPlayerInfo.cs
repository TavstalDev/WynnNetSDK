using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents detailed player information including friends, party, and guild locations.
/// </summary>
public class MapPlayerInfo
{
    /// <summary>
    /// The UUID of the player.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    /// The username of the player.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The display nickname of the player.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string? Nickname { get; set; }

    /// <summary>
    /// The character name of the player.
    /// </summary>
    [JsonPropertyName("character")]
    public string Character { get; set; } = string.Empty;

    /// <summary>
    /// The server the player is currently on.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The X coordinate of the player.
    /// </summary>
    [JsonPropertyName("x")]
    public int X { get; set; }

    /// <summary>
    /// The Y coordinate of the player.
    /// </summary>
    [JsonPropertyName("y")]
    public int Y { get; set; }

    /// <summary>
    /// The Z coordinate of the player.
    /// </summary>
    [JsonPropertyName("z")]
    public int Z { get; set; }

    /// <summary>
    /// The list of the player's friends and their locations.
    /// </summary>
    [JsonPropertyName("friends")]
    public List<MapPlayerLocation> Friends { get; set; } = [];

    /// <summary>
    /// The list of the player's party members and their locations.
    /// </summary>
    [JsonPropertyName("party")]
    public List<MapPlayerLocation> Party { get; set; } = [];

    /// <summary>
    /// The list of the player's guild members and their locations.
    /// </summary>
    [JsonPropertyName("guild")]
    public List<MapPlayerLocation> Guild { get; set; } = [];
}
