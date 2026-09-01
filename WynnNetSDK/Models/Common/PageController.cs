using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common;

public class PageController
{
    [JsonPropertyName("count")]
    public int Count { get; set; }
    
    [JsonPropertyName("current_count")]
    public int CurrentCount { get; set; }
    
    [JsonPropertyName("pages")]
    public int Pages { get; set; }
    
    [JsonPropertyName("prev")]
    public int? Prev { get; set; }
    
    [JsonPropertyName("current")]
    public int Current { get; set; }
    
    [JsonPropertyName("next")]
    public int? Next { get; set; }
}