using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

public class Vector3
{
    [JsonPropertyName("x")] 
    public double X { get; set; }

    [JsonPropertyName("y")] 
    public double Y { get; set; }

    [JsonPropertyName("z")]
    public double Z { get; set; }
}