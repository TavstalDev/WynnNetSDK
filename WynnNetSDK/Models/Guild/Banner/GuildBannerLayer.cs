using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Models.Guild.Banner;

/// <summary>
/// Represents a single layer of a guild banner.
/// </summary>
public class GuildBannerLayer
{
    /// <summary>
    /// The colour of this banner layer.
    /// </summary>
    [JsonPropertyName("color")]
    public EColor Color { get; set; }

    /// <summary>
    /// The pattern applied to this banner layer.
    /// </summary>
    [JsonPropertyName("pattern")]
    public EBannerPattern Pattern { get; set; }
}