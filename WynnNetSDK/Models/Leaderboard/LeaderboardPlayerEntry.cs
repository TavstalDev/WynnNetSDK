using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;
using Tavstal.WynnNetSDK.Models.Player;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;

public class LeaderboardPlayerEntry : LeaderboardEntry
{
    [JsonPropertyName("metaScore")]
    public int MetaScore { get; set; }
    
    [JsonPropertyName("score")]
    public double Score { get; set; }
    
    [JsonPropertyName("metadata")]
    public LeaderboardMetadata? Metadata { get; set; }
    
    [JsonPropertyName("restricted")]
    public bool Restricted { get; set; }
    
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }
    
    [JsonPropertyName("characterUuid")]
    public string? CharacterUuid { get; set; }
    
    [JsonPropertyName("characterType")]
    public string? CharacterType { get; set; }
    
    [JsonPropertyName("characterData")]
    public PlayerDetailedCharacter? CharacterData { get; set; }
    
    [JsonPropertyName("rank")]
    public string? Rank { get; set; }
    
    [JsonPropertyName("supportRank")]
    public string? SupportRank { get; set; }
    
    [JsonPropertyName("shortenedRank")]
    public string? ShortenedRank { get; set; }
    
    [JsonPropertyName("legacyRankColour")]
    public Dictionary<string, string>? LegacyRankColour { get; set; }
    
    [JsonPropertyName("rankBadge")]
    public string? RankBadge { get; set; }
    
    [JsonPropertyName("previousRanking")]
    public int? PreviousRanking { get; set; }
}