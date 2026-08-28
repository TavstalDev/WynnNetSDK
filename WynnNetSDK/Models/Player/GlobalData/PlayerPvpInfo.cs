using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

public class PlayerPvpInfo
{
    [JsonPropertyName("kills")]
    public int Kills { get; set; }
    
    [JsonPropertyName("deaths")]
    public int Deaths { get; set; }
}