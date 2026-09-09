using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;
using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;

/// <summary>
/// Represents a player entry on the leaderboard.
/// </summary>
public class LeaderboardPlayerEntry : LeaderboardEntry
{
    /// <summary>
    /// The meta score of the player.
    /// </summary>
    [JsonPropertyName("metaScore")]
    public int MetaScore { get; set; }

    /// <summary>
    /// The score of the player.
    /// </summary>
    [JsonPropertyName("score")]
    public double Score { get; set; }

    /// <summary>
    /// The metadata associated with this player entry.
    /// </summary>
    [JsonPropertyName("metadata")]
    public LeaderboardMetadata? Metadata { get; set; }

    /// <summary>
    /// Whether this player entry is restricted.
    /// </summary>
    [JsonPropertyName("restricted")]
    public bool Restricted { get; set; }

    /// <summary>
    /// The tag or prefix of the player.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>
    /// The UUID of the player's character.
    /// </summary>
    [JsonPropertyName("characterUuid")]
    public string? CharacterUuid { get; set; }

    /// <summary>
    /// The type of the player's character.
    /// </summary>
    [JsonPropertyName("characterType")]
    public string? CharacterType { get; set; }

    /// <summary>
    /// The detailed character data of the player.
    /// </summary>
    [JsonPropertyName("characterData")]
    public PlayerDetailedCharacter? CharacterData { get; set; }

    /// <summary>
    /// The rank of the player.
    /// </summary>
    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    /// <summary>
    /// The support rank of the player.
    /// </summary>
    [JsonPropertyName("supportRank")]
    public string? SupportRank { get; set; }

    /// <summary>
    /// The shortened version of the player's rank.
    /// </summary>
    [JsonPropertyName("shortenedRank")]
    public string? ShortenedRank { get; set; }

    /// <summary>
    /// The legacy rank colour of the player.
    /// </summary>
    [JsonPropertyName("legacyRankColour")]
    public Dictionary<string, string>? LegacyRankColour { get; set; }

    /// <summary>
    /// The rank badge image of the player.
    /// </summary>
    [JsonPropertyName("rankBadge")]
    public string? RankBadge { get; set; }

    /// <summary>
    /// The previous ranking of the player.
    /// </summary>
    [JsonPropertyName("previousRanking")]
    public int? PreviousRanking { get; set; }
}
