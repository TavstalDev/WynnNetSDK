using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Models.Guild.Territory;

namespace Tavstal.WynnNetSDK.Models.Guild;

public class GuildTerritory
{
    [JsonPropertyName("guild")]
    public GuildInfo Guild { get; set; } = new();
    
    [JsonPropertyName("acquired")]
    public DateTime Acquired { get; set; }
    
    [JsonPropertyName("hq")]
    public bool IsHeadquarters { get; set; }
    
    [JsonPropertyName("resources")]
    public List<TerritoryResource> Resources { get; set; } = [];
    
    [JsonPropertyName("links")]
    public List<string> Links { get; set; } = [];
    
    [JsonPropertyName("treasury")]
    public EScaleLevel Treasury { get; set; }
    
    [JsonPropertyName("defences")]
    public EScaleLevel Defences { get; set; }
    
    [JsonPropertyName("location")]
    public TerritoryLocation Location { get; set; } = new();
}