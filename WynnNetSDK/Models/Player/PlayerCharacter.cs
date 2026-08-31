using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerCharacter
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
    
    [JsonPropertyName("gamemode")]
    public List<string> Gamemode { get; set; } = [];
    
   [JsonPropertyName("meta")]
   public PlayerCharacterMeta Meta { get; set; } = new();
}