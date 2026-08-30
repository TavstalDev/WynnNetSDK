using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class ClassDetail
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("lore")]
    public string Lore { get; set; } = string.Empty;
    
    [JsonPropertyName("overallDifficulty")]
    public int OverallyDifficulty {  get; set; }
    
    [JsonPropertyName("overallMax")]
    public int OverallMax { get; set; }
    
    [JsonPropertyName("archtypes")]
    public Dictionary<string, ArchtypeDetail> Archtypes { get; set; } = [];
}