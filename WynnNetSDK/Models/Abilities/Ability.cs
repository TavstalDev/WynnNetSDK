using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Abilities;

public class Ability
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("icon")]
    public ItemIcon Icon { get; set; } = new();
    
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
    
    [JsonPropertyName("coordinates")]
    public Vector2 Coordinates { get; set; } = new();
    
    [JsonPropertyName("description")]
    public List<string> Description { get; set; } = [];
    
    [JsonPropertyName("requirements")]
    public Dictionary<string, int> Requirements { get; set; } = [];
    
    [JsonPropertyName("links")]
    public List<string> Links {  get; set; } = [];
    
    [JsonPropertyName("locks")]
    public List<string>? Locks { get; set; }
    
    [JsonPropertyName("page")]
    public int Page { get; set; }
}