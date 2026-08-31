using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

public class ErrorResponse
{
    [JsonPropertyName("error")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("detail")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("code")] 
    public int Code { get; set; } = -1;

    [JsonPropertyName("objects")] 
    public Dictionary<string, object>? Objects { get; set; } = null;
}