using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Models.Guild.Banner;

/// <summary>
/// Represents a guild's banner design.
/// </summary>
public class GuildBanner
{
    /// <summary>
    /// The base colour of the banner.
    /// </summary>
    [JsonPropertyName("base")]
    public EColor Base { get; set; }

    /// <summary>
    /// The tier of the banner.
    /// </summary>
    [JsonPropertyName("tier")]
    public int Tier { get; set; }

    /// <summary>
    /// The structure name used in the banner.
    /// </summary>
    [JsonPropertyName("structure")]
    public string Structure { get; set; } = string.Empty;

    /// <summary>
    /// The layers that make up the banner design.
    /// </summary>
    [JsonPropertyName("layers")]
    public List<GuildBannerLayer> Layers { get; set; } = [];
}
