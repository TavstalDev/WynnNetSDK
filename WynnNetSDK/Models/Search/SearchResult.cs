using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Guild;
using Tavstal.WynnNetSDK.Models.Guild.Territory;
using Tavstal.WynnNetSDK.Models.Items;

namespace Tavstal.WynnNetSDK.Models.Search;

public class SearchResult
{
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
    
    [JsonPropertyName("players")]
    public Dictionary<string, string>? Players { get; set; }
    
    [JsonPropertyName("guilds")]
    public Dictionary<string, SearchGuildInfo>? Guilds { get; set; }
    
    [JsonPropertyName("items")]
    public List<Item>? Items { get; set; }
    
    [JsonPropertyName("guildsPrefix")]
    public Dictionary<string, GuildInfo>? GuildsPrefix { get; set; }
    
    [JsonPropertyName("territories")]
    public Dictionary<string, TerritoryLocation>? Territories { get; set; }
    
    [JsonPropertyName("discoveries")]
    public Dictionary<string, TerritoryLocation>? Discoveries  { get; set; }
}