using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Player.GlobalData;

namespace Tavstal.WynnNetSDK.Models.Guild.Members;

public class GuildMemberGlobalData
{
    [JsonPropertyName("contentCompletion")]
    public int ContentCompletion { get; set; }
    
    [JsonPropertyName("wars")]
    public int Wars { get; set; }
    
    [JsonPropertyName("totalLevel")]
    public int TotalLevel { get; set; }
    
    [JsonPropertyName("mobsKilled")]
    public int MobsKilled { get; set; }
    
    [JsonPropertyName("chestsFound")]
    public int ChestsFound { get; set; }
    
    [JsonPropertyName("dungeons")]
    public PlayerDungeons Dungeons { get; set; } = new();
    
    [JsonPropertyName("raids")]
    public PlayerDungeons Raids { get; set; } = new();
    
    [JsonPropertyName("worldEvents")]
    public int WorldEvents { get; set; }
    
    [JsonPropertyName("lootruns")]
    public int Lootruns { get; set; }
    
    [JsonPropertyName("caves")]
    public int Caves { get; set; }
    
    [JsonPropertyName("completedQuests")]
    public int CompletedQuests {  get; set; }
    
    [JsonPropertyName("guildRaids")]
    public PlayerDungeons GuildRaids { get; set; } = new();
    
    [JsonPropertyName("raidStats")]
    public PlayerRaidStats RaidStats { get; set; } = new();
    
    [JsonPropertyName("pvp")]
    public PlayerPvpInfo PvP { get; set; } = new();
    
    [JsonPropertyName("currentGuildRaids")]
    public PlayerDungeons CurrentGuildRaids { get; set; } = new();

    [JsonPropertyName("playtime")]
    public double Playtime { get; set; }
}