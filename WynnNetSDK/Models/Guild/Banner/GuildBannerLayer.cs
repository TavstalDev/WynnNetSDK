using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Models.Guild.Banner;

public class GuildBannerLayer
{
    [JsonPropertyName("color")]
    public EColor Color { get; set; }
    
    [JsonPropertyName("pattern")]
    public EBannerPattern Pattern { get; set; }
}