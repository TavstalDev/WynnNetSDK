using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Guild;

/// <summary>
/// Represents a basic guild lookup result.
/// </summary>
public class GuildResult
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
}
