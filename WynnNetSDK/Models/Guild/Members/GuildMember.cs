using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

public class GuildMember
{
    [JsonPropertyName("uuid")]
    public string Uuid { get; set; } = string.Empty;
    
    [JsonPropertyName("username")]
    public string Username { get; set; } = string.Empty;
    
    [JsonPropertyName("online")]
    public bool Online { get; set; }
    
    [JsonPropertyName("lastJoin")]
    public DateTime LastJoin { get; set; }
    
    [JsonPropertyName("server")]
    public string? Server { get; set; }
    
    [JsonPropertyName("contributed")]
    public int Contributed { get; set; }
    
    [JsonPropertyName("contributionRank")]
    public int ContributionRank { get; set; }
    
    [JsonPropertyName("joined")]
    public DateTime Joined { get; set; }
    
    [JsonPropertyName("weekly")]
    public GuildMemberWeekly Weekly { get; set; } = new();

    [JsonPropertyName("globalData")]
    public GuildMemberGlobalData GlobalData { get; set; } = new();
    
    [JsonPropertyName("restrictions")]
    public GuildMemberDataRestrictions Restrictions { get; set; } = new();
}