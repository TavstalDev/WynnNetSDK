using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Http.Requests.Search;
using Tavstal.WynnNetSDK.Models.Guild;
using Tavstal.WynnNetSDK.Models.Guild.Territory;
using Tavstal.WynnNetSDK.Models.Items;

namespace Tavstal.WynnNetSDK.Models.Search;

/// <summary>
/// Represents the response from the search endpoint containing matching results across categories.
/// </summary>
public class SearchResult
{
    /// <summary>
    /// The original search query string.
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
    
    /// <summary>
    /// Matching players mapped by UUID to username, or null if none found.
    /// </summary>
    [JsonPropertyName("players")]
    public Dictionary<string, string>? Players { get; set; }
    
    /// <summary>
    /// Matching guilds mapped by name, or null if none found.
    /// </summary>
    [JsonPropertyName("guilds")]
    public Dictionary<string, SearchGuildInfo>? Guilds { get; set; }
    
    /// <summary>
    /// Matching items, or null if none found.
    /// </summary>
    [JsonPropertyName("items")]
    public List<Item>? Items { get; set; }
    
    /// <summary>
    /// Matching guilds by prefix, or null if none found.
    /// </summary>
    [JsonPropertyName("guildsPrefix")]
    public Dictionary<string, GuildInfo>? GuildsPrefix { get; set; }
    
    /// <summary>
    /// Matching territories, or null if none found.
    /// </summary>
    [JsonPropertyName("territories")]
    public Dictionary<string, TerritoryLocation>? Territories { get; set; }
    
    /// <summary>
    /// Matching discoveries, or null if none found.
    /// </summary>
    [JsonPropertyName("discoveries")]
    public Dictionary<string, TerritoryLocation>? Discoveries  { get; set; }
}