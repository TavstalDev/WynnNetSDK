using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class SkillPoints
{
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
    
    [JsonPropertyName("dexterity")]
    public int Dexterity {  get; set; }
    
    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }
    
    [JsonPropertyName("defence")]
    public int Defence {  get; set; }
    
    [JsonPropertyName("agility")]
    public int Agility { get; set; }
}