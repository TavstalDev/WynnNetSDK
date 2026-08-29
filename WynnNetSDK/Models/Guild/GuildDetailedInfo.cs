using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Guild.Banner;
using Tavstal.WynnNetSDK.Models.Guild.Members;
using Tavstal.WynnNetSDK.Models.Guild.Season;

namespace Tavstal.WynnNetSDK.Models.Guild;

public class GuildDetailedInfo
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
    
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
    
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }
    
    [JsonPropertyName("territories")]
    public int Territories { get; set; }
    
    [JsonPropertyName("wars")]
    public int Wars { get; set; }
    
    [JsonPropertyName("raids")]
    public int Raids { get; set; }
    
    [JsonPropertyName("created")]
    public DateTime Created { get; set; }
    
    [JsonPropertyName("members")]
    public GuildMembers Members { get; set; } = new();
    
    [JsonPropertyName("online")]
    public int Online { get; set; }
    
    [JsonPropertyName("banner")]
    public GuildBanner Banner { get; set; } = new();
    
    [JsonPropertyName("seasonRanks")]
    public Dictionary<string, GuildSeasonRank> SeasonRanks { get; set; } = [];
    
    [JsonPropertyName("ranking")]
    public GuildRanking? Ranking { get; set; }
}