using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerProfessionInfo
{
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    [JsonPropertyName("xpPercent")]
    public int XpPercent { get; set; }
}