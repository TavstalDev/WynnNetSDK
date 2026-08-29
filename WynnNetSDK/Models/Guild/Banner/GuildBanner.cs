using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Guild.Banner;

public class GuildBanner
{
    [JsonPropertyName("base")]
    public EColor Base { get; set; }
    
    [JsonPropertyName("tier")]
    public int Tier { get; set; }
    
    [JsonPropertyName("structure")]
    public string Structure { get; set; } = string.Empty;
    
    [JsonPropertyName("layers")]
    public List<GuildBannerLayer> Layers { get; set; } = [];
}