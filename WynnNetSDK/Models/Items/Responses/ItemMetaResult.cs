using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Responses;

public class ItemMetaResult
{
    [JsonPropertyName("filters")]
    public ItemMetaFilters Filters { get; set; } = new();
    
    [JsonPropertyName("static")]
    public Dictionary<string, int> Static { get; set; } = [];
}