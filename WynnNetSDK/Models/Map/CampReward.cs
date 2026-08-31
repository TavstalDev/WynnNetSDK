using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Map.Enums;

namespace Tavstal.WynnNetSDK.Models.Map;

public class CampReward
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public ECampReward Type { get; set; }
    
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
    
    [JsonPropertyName("always")]
    public bool Always { get; set; }
    
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
    
    [JsonPropertyName("shiny")]
    public bool Shiny { get; set; }
}