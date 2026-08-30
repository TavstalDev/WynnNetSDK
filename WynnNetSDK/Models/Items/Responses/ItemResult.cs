using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Models.Items.Responses;

public class ItemResult
{
    [JsonPropertyName("controller")]
    public PageController Controller { get; set; } = new();
    
    [JsonPropertyName("results")]
    public List<Item> Results { get; set; } = [];
}