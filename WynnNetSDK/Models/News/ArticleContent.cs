using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.News.Polls;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Models.News;

public class ArticleContent
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("focus")]
    public bool Focus { get; set; }
    
    [JsonPropertyName("content")]
    public JsonElement Content { get; set; } = new();
    
    [JsonPropertyName("discord")]
    public bool Discord { get; set; }
    
    [JsonPropertyName("website")]
    public bool Website { get; set; }
    
    public string? ContentAsString()
    {
        if (Content.ValueKind != JsonValueKind.String)
            return null;
        return Content.GetString();
    }

    public PublisherPollQuestion? ContentAsPoll()
    {
        if (Content.ValueKind != JsonValueKind.Object)
            return null;
        return Content.Deserialize(WynnNetSDKJsonContext.Default.PublisherPollQuestion);
    }
}