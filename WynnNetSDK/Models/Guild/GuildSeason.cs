using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Season;

namespace Tavstal.WynnNetSDK.Models.Guild;

public class GuildSeason
{
    [JsonPropertyName("territoryHoldingSrPerHour")]
    public int TerritoryHoldingSrPerHour { get; set; }
    
    [JsonPropertyName("srPerWar")]
    public int SrPerWar { get; set; }
    
    [JsonPropertyName("ratingRewards")]
    public List<GuildSeasonReward> RatingRewards { get; set; } = [];
    
    [JsonPropertyName("leaderboardRewards")]
    public List<GuildSeasonReward> LeaderboardRewards { get; set; } = [];
    
    [JsonPropertyName("initDate")]
    public DateTime? InitDate { get; set; }
    
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }
}