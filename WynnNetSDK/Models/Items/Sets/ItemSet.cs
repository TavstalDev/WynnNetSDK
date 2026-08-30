using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Sets;

public class ItemSet
{
    [JsonPropertyName("internalName")]
    public string InternalName { get; set; } = string.Empty;
    
    [JsonPropertyName("bonuses")]
    public Dictionary<string, ItemSetBonus> Bonuses { get; set; } = new();
    
    [JsonPropertyName("parts")]
    public List<string> Parts { get; set; } = [];
}