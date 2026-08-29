using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items;

public class ItemResult
{
    [JsonPropertyName("controller")]
    public ItemController Controller { get; set; } = new();
    
    [JsonPropertyName("results")]
    public List<Item> Results { get; set; } = [];
}