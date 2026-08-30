using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

public class ItemMetaFilters
{
    [JsonPropertyName("type")]
    public List<string> Type { get; set; } = [];
    
    [JsonPropertyName("advanced")]
    public Dictionary<string, List<string>> Advanced { get; set; } = [];
    
    [JsonPropertyName("tier")]
    public Dictionary<string, List<string>> Tier { get; set; } = [];
    
    [JsonPropertyName("identifications")]
    public List<string> Identifications  { get; set; } = [];
    
    [JsonPropertyName("majorIds")]
    public List<string> MajorIds { get; set; } = [];
    
    [JsonPropertyName("levelRange")]
    public List<int> LevelRange { get; set; } = [];
}