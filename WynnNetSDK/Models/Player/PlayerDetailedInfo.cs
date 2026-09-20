using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Player.GlobalData;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Player;

/// <summary>
/// Represents detailed information about a Wynncraft player including all characters and global data.
/// </summary>
public class PlayerDetailedInfo
{
    /// <summary>
    /// The player's username.
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Whether the player is currently online.
    /// </summary>
    [JsonPropertyName("online")]
    public bool Online { get; set; }

    /// <summary>
    /// The server the player is currently connected to, or null if offline.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The UUID of the currently active character, or null if none.
    /// </summary>
    [JsonPropertyName("activeCharacter")]
    public string? ActiveCharacter { get; set; }

    /// <summary>
    /// The player's display nickname.
    /// </summary>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;

    /// <summary>
    /// The player's unique identifier.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;

    /// <summary>
    /// The player's rank title.
    /// </summary>
    [JsonPropertyName("rank")]
    public string Rank { get; set; } = string.Empty;

    /// <summary>
    /// The player's support tier rank.
    /// </summary>
    [JsonPropertyName("supportRank")]
    public string SupportRank { get; set; } = string.Empty;

    /// <summary>
    /// The shortened version of the player's rank.
    /// </summary>
    [JsonPropertyName("shortenedRank")]
    public string ShortenedRank { get; set; } = string.Empty;

    /// <summary>
    /// The legacy color data for the player's rank display.
    /// </summary>
    [JsonPropertyName("legacyRankColour")]
    public Dictionary<string, string> LegacyRankColour { get; set; } = new();

    /// <summary>
    /// The badge icon associated with the player's rank.
    /// </summary>
    [JsonPropertyName("rankBadge")]
    public string RankBadge { get; set; } = string.Empty;

    /// <summary>
    /// Whether the player has veteran status.
    /// </summary>
    [JsonPropertyName("veteran")]
    public bool Veteran { get; set; }

    /// <summary>
    /// The date and time the player last joined.
    /// </summary>
    [JsonPropertyName("lastJoin")]
    public DateTime? LastJoin { get; set; }

    /// <summary>
    /// The player's guild information, or null if not in a guild.
    /// </summary>
    [JsonPropertyName("guild")]
    public PlayerGuildInfo? Guild { get; set; }

    /// <summary>
    /// The player's current global rankings.
    /// </summary>
    [JsonPropertyName("ranking")]
    public Dictionary<string, int> Ranking { get; set; } = new();

    /// <summary>
    /// The player's previous global rankings.
    /// </summary>
    [JsonPropertyName("previousRanking")]
    public Dictionary<string, int> PreviousRanking { get; set; } = new();

    /// <summary>
    /// The date and time the player first joined.
    /// </summary>
    [JsonPropertyName("firstJoin")]
    public DateTime FirstJoin { get; set; }

    /// <summary>
    /// The total playtime in hours.
    /// </summary>
    [JsonPropertyName("playtime")]
    public double Playtime { get; set; }

    /// <summary>
    /// Aggregated global data across all characters.
    /// </summary>
    [JsonPropertyName("globalData")]
    public PlayerGlobalData GlobalData { get; set; } = new();

    /// <summary>
    /// The player's featured stats as raw JSON elements. Use FeaturedStatsAsString() instead.
    /// </summary>
    [JsonPropertyName("featuredStats")]
    [Obsolete("Please use FeaturedStatsAsString().")]
    public Dictionary<string, JsonElement> FeaturedStats { get; set; } = new();

    /// <summary>
    /// The player's profile wallpaper selection.
    /// </summary>
    [JsonPropertyName("wallpaper")]
    public string Wallpaper { get; set; } = "default";

    /// <summary>
    /// The player's profile avatar selection.
    /// </summary>
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; } = "default";

    /// <summary>
    /// The data access restrictions for the player.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public PlayerDataRestrictions Restrictions { get; set; } = new();

    /// <summary>
    /// A dictionary of all player characters keyed by UUID.
    /// </summary>
    [JsonPropertyName("characters")]
    public Dictionary<string, PlayerDetailedCharacter> Characters { get; set; } = new();

    /// <summary>
    /// Converts the featured stats from raw JSON elements to a string dictionary.
    /// </summary>
    /// <returns>A dictionary of featured stats with string values.</returns>
    public Dictionary<string, string> FeaturedStatsAsString()
    {
        Dictionary<string, string> result = [];
        foreach (var elem in FeaturedStats)
        {
            switch (elem.Value.ValueKind)
            {
                case JsonValueKind.String:
                {
                    result[elem.Key] = elem.Value.GetRawText();
                    continue;
                }
                case JsonValueKind.Number:
                {
                    result[elem.Key] = elem.Value.GetInt32().ToString();
                    continue;
                }
            }
        }
        return result;
    }
}
