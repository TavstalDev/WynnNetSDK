using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Season;

public class GuildSeasonRank
{
    [JsonPropertyName("rating")]
    public int Rating { get; set; }
    
    [JsonPropertyName("finalTerritories")]
    public int FinalTerritories { get; set; }
}