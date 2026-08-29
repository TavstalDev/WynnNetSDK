using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

public class ItemRequirement
{
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    
    [JsonPropertyName("classRequirement")]
    public string? ClassRequirement { get; set; }
    
    [JsonPropertyName("strength")]
    public int? Strength { get; set; }
    
    [JsonPropertyName("dexterity")]
    public int? Dexterity { get; set; }
    
    [JsonPropertyName("intelligence")]
    public int? Intelligence { get; set; }
    
    [JsonPropertyName("defence")]
    public int? Defence { get; set; }
    
    [JsonPropertyName("agility")]
    public int? Agility { get; set; }
}