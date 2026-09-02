using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Search;

public class SearchGuildInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
}