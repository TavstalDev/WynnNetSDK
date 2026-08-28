using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

public class PlayerRaidStats
{
    [JsonPropertyName("damageTaken")]
    public int DamageTaken { get; set; }
    
    [JsonPropertyName("damageDealt")]
    public int DamageDealt { get; set; }
    
    [JsonPropertyName("healthHealed")]
    public int HealthHealed { get; set; }
    
    [JsonPropertyName("deaths")]
    public int Deaths { get; set; }
    
    [JsonPropertyName("buffsTaken")]
    public int BuffsTaken { get; set; }
    
    [JsonPropertyName("gambitsUsed")]
    public int GambitsUsed { get; set; }
}