using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class Class
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("overallDifficulty")]
    public int OverallDifficultx { get; set; }
}