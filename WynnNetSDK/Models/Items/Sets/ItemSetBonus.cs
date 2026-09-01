using System.Text.Json;
using System.Text.Json.Serialization;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Items.Sets;

public class ItemSetBonus
{
    [JsonPropertyName("major")]
    public List<string> Major { get; set; } = [];
    
    [JsonPropertyName("minor")]
    [Obsolete("Please use GetMinor() instead.")]
    public Dictionary<string, JsonElement> Minor { get; set; } = [];

    public Dictionary<string, string> GetMinor()
    {
        var result = new Dictionary<string, string>();

        foreach (var minor in Minor)
        {
            result.Add(minor.Key, minor.Value.GetRawText());
        }
        
        return result;
    }
}