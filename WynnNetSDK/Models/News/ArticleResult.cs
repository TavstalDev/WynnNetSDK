using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.News;

public class ArticleResult
{
    [JsonPropertyName("controller")]
    public PageController Controller { get; set; } = new();
    
    [JsonPropertyName("results")]
    public Dictionary<string, ArticleInfo> Results { get; set; } = [];
}