using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

public class GuildMemberWeekly
{
    [JsonPropertyName("completed")]
    public bool Completed { get; set; }
    
    [JsonPropertyName("streak")]
    public int Streak { get; set; }
}