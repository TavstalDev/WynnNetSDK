using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class AspectTier
{
    [JsonPropertyName("threshold")]
    public int Threshold {  get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}