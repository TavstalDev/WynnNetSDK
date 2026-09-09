using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild;

/// <summary>
/// Represents basic information about a guild.
/// </summary>
public class GuildInfo
{
    /// <summary>
    /// The name of the guild.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The UUID of the guild.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>
    /// The tag or prefix of the guild.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string Prefix { get; set; } = string.Empty;

    /// <summary>
    /// The name of the guild's headquarters territory.
    /// </summary>
    [JsonPropertyName("hq")]
    public string Headquarters { get; set; } = string.Empty;
}