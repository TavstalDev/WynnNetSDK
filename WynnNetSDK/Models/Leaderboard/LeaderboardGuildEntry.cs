using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Banner;
using Tavstal.WynnNetSDK.Models.Leaderboard.Metadata;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Leaderboard;

public class LeaderboardGuildEntry : LeaderboardEntry
{
    [JsonPropertyName("metaScore")]
    public int MetaScore { get; set; }
    
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
    
    [JsonPropertyName("score")]
    public double Score { get; set; }
    
    [JsonPropertyName("metadata")]
    [JsonConverter(typeof(LeaderboardMetadataDeserializer))]
    public LeaderboardMetadata? Metadata { get; set; }
    
    [JsonPropertyName("banner")]
    public GuildBanner Banner { get; set; } = new();
    
    [JsonPropertyName("previousRanking")]
    public int? PreviousRanking { get; set; }
}