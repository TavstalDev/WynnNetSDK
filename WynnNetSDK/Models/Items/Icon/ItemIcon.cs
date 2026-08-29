using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Icon;

public class ItemIcon
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("format")]
    public string Format { get; set; } = string.Empty;
    
    [JsonPropertyName("value")]
    public ItemIconValue Value { get; set; } = new();
}