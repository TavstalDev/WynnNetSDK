using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class ArchtypeDetail
{
    [JsonPropertyName("name")]
    public string Name {  get; set; } = string.Empty;
    
    [JsonPropertyName("difficulty")]
    public int Difficulty { get; set; }
    
    [JsonPropertyName("max")]
    public int Max { get; set; }
    
    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;
    
    [JsonPropertyName("damage")]
    public int Damage { get; set; }
    
    [JsonPropertyName("defence")]
    public int Defence { get; set; }
    
    [JsonPropertyName("range")]
    public int Range { get; set; }
    
    [JsonPropertyName("speed")]
    public int Speed { get; set; }
}