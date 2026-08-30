using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class Aspect
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();
    
    [JsonPropertyName("rarity")]
    public string Rarity {  get; set; } = string.Empty;
    
    [JsonPropertyName("requiredClass")]
    public string RequiredClass { get; set; } = string.Empty;
    
    [JsonPropertyName("tiers")]
    public Dictionary<string, AspectTier> Tiers { get; set; } = [];
}