using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Classes;

public class Archtype
{
    [JsonPropertyName("name")]
    public string Name { get; set; } =  string.Empty;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
    
    [JsonPropertyName("shortDescription")]
    public string ShortDescription { get; set; } = string.Empty;
    
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();
    
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
}