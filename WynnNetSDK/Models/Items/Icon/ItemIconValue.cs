using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Icon;

public class ItemIconValue
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("customModelData")]
    public ItemCustomModel CustomModelData { get; set; } = new();
}