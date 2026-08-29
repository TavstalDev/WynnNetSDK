using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

public class GuildMembers
{
    [JsonPropertyName("total")]
    public int Total { get; set; }
    
    [JsonPropertyName("owner")]
    public Dictionary<string, GuildMember> Owner { get; set; } = [];
    
    [JsonPropertyName("chief")]
    public Dictionary<string, GuildMember> Chief { get; set; } = [];
    
    [JsonPropertyName("strategist")]
    public Dictionary<string, GuildMember> Strategist { get; set; } = [];
    
    [JsonPropertyName("recruiter")]
    public Dictionary<string, GuildMember> Recruiter { get; set; } = [];
    
    [JsonPropertyName("recruit")]
    public Dictionary<string, GuildMember> Recruit { get; set; } = [];
}