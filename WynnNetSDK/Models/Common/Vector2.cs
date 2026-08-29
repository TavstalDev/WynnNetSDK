using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

public class Vector2
{
    [JsonPropertyName("x")] 
    public int X { get; set; }

    [JsonPropertyName("y")] 
    public int Y { get; set; }
}