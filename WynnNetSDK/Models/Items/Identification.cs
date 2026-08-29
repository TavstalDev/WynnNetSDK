using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

public class Identification
{
    [JsonPropertyName("min")]
    public int Min { get; set; }
    
    [JsonPropertyName("raw")]
    public int Raw { get; set; }
    
    [JsonPropertyName("max")]
    public int Max { get; set; }
}