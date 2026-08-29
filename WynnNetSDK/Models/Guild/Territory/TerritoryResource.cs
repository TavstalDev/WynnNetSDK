using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild.Territory;

public class TerritoryResource
{
    [JsonPropertyName("type")]
    public ETerritoryResourceType Type { get; set; }
    
    [JsonPropertyName("generation")]
    public int Generation { get; set; }
    
    [JsonPropertyName("stored")]
    public int Stored { get; set; }
    
    [JsonPropertyName("limit")]
    public int Limit { get; set; }
}