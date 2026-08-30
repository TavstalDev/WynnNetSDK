using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Responses;

public class ItemMetaStaticResult
{
    [JsonPropertyName("attackSpeed")]
    public Dictionary<string, int> AttackSpeed { get; set; } = [];
    
    [JsonPropertyName("emblem")]
    public Dictionary<string, int> Emblem { get; set; } = [];
    
    [JsonPropertyName("gathering")]
    public Dictionary<string, int> Gathering { get; set; } = [];
    
    [JsonPropertyName("identifications")]
    public Dictionary<string, int> Identifications { get; set; } = [];
    
    [JsonPropertyName("majorIds")]
    public Dictionary<string, int> MajorIds { get; set; } = [];
    
    [JsonPropertyName("set")]
    public Dictionary<string, int> Set { get; set; } = [];
    
    [JsonPropertyName("subType")]
    public Dictionary<string, int> SubType { get; set; } = [];
    
    [JsonPropertyName("tier")]
    public Dictionary<string, int> Tier { get; set; } = [];
    
    [JsonPropertyName("type")]
    public Dictionary<string, int> Type { get; set; } = [];
}