using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Classes;
using Tavstal.WynnNetSDK.Models.Player.GlobalData;

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerDetailedCharacter
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("reskin")]
    public string? Reskin { get; set; }
    
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; } = string.Empty;
    
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    [JsonPropertyName("xp")]
    public int Xp { get; set; }
    
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }
    
    [JsonPropertyName("totalLevel")]
    public int TotalLevel {  get; set; }
    
    [JsonPropertyName("preEconomy")]
    public bool? PreEconomy { get; set; }
    
    [JsonPropertyName("gamemode")]
    public List<string> Gamemode { get; set; } = [];
    
    [JsonPropertyName("contentCompletion")]
    public int ContentCompletion { get; set; }
    
    [JsonPropertyName("wars")]
    public int Wars { get; set; }
    
    [JsonPropertyName("playtime")]
    public float Playtime { get; set; }
    
    [JsonPropertyName("mobsKilled")]
    public int MobsKilled { get; set; }
    
    [JsonPropertyName("chestsFound")]
    public int ChestsFound { get; set; }
    
    [JsonPropertyName("ItemsIdentified")]
    public int ItemsIdentified { get; set; }
    
    [JsonPropertyName("blocksWalked")]
    public int BlocksWalked { get; set; }
    
    [JsonPropertyName("logins")]
    public int Logins { get; set; }
    
    [JsonPropertyName("deaths")]
    public int Deaths {  get; set; }
    
    [JsonPropertyName("discoveries")]
    public int Discoveries { get; set; }
    
    [JsonPropertyName("pvp")]
    public PlayerPvpInfo PvP { get; set; } = new();
    
    [JsonPropertyName("skillPoints")]
    public SkillPoints SkillPoints { get; set; } = new();
    
    [JsonPropertyName("professions")]
    public Dictionary<string, PlayerProfessionInfo> Professions { get; set; } = new();
    
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

    [JsonPropertyName("quests")] 
    public List<string> Quests { get; set; } = [];
    
    [JsonPropertyName("restrictions")]
    public PlayerDataRestrictions Restrictions { get; set; } = new();
    
    [JsonPropertyName("removedStats")]
    public List<string> RemovedStats { get; set; } = [];
    
    [JsonPropertyName("meta")]
    public PlayerCharacterMeta Meta { get; set; } = new();
}