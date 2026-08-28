using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

public class PlayerDungeons
{
    [JsonPropertyName("total")]
    public int Total { get; set; }
    
    [JsonPropertyName("list")]
    public Dictionary<string, int> List { get; set; } = new ();
}