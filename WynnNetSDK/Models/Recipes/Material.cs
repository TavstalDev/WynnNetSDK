using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Recipes;

public class Material
{
    [JsonPropertyName("item")]
    public string Item { get; set; } = string.Empty;
    
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
}