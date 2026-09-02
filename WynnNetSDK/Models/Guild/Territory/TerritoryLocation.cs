using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Territory;

public class TerritoryLocation
{
    [JsonPropertyName("start")]
    public List<int> Start { get; set; } = [];
    
    [JsonPropertyName("end")]
    public List<int> End { get; set; } = [];
}