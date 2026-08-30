using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items;
using Tavstal.WynnNetSDK.Models.Items.Enums;

namespace Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;

public class ItemSearchRequestBody
{
    [JsonPropertyName("query")]
    public string? Query { get; set; }
    
    [JsonPropertyName("type")]
    public List<EItemType>? Type { get; set; }
    
    [JsonPropertyName("tier")]
    public List<ETier>? Tier { get; set; }
    
    [JsonPropertyName("attackSpeed")]
    public List<EAttackSpeed>? AttackSpeed { get; set; }
    
    [JsonPropertyName("levelRange")]
    public List<int>? LevelRange { get; set; }
    
    [JsonPropertyName("professions")]
    public List<EGathering>? Professions { get; set; }
    
    [JsonPropertyName("identifications")]
    public List<EIdentification>? Identifications { get; set; }
    
    [JsonPropertyName("majorIds")]
    public List<EMajorId>? MajorIds { get; set; }
}