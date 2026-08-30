using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

public class IntRange
{
    [JsonPropertyName("minimum")]
    public int Minimum { get; set; }
    
    [JsonPropertyName("maximum")]
    public int Maximum { get; set; }
}