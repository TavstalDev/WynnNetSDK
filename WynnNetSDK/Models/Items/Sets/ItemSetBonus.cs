using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Items.Sets;

public class ItemSetBonus
{
    [JsonPropertyName("major")]
    public List<string> Major { get; set; } = [];
    
    [JsonPropertyName("minor")]
    public Dictionary<string, string> Minor { get; set; } = []; 
}