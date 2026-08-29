using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

public class GuildMemberDataRestrictions
{
    [JsonPropertyName("online_status")]
    public bool OnlineStatus { get; set; }
    
    [JsonPropertyName("main_access")]
    public bool MainAccess { get; set; }
    
    [JsonPropertyName("guild_high_ranked_access")]
    public bool GuildHighRankedAccess { get; set; }
}