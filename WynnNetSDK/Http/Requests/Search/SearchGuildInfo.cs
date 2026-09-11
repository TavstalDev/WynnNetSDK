using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Http.Requests.Search;

/// <summary>
/// Contains basic information about a guild in search results.
/// </summary>
public class SearchGuildInfo
{
    /// <summary>
    /// The name of the guild.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The prefix of the guild.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;
}
