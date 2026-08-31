using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

public class MapQuests
{
    [JsonPropertyName("quests")]
    public int Quests { get; set; }
}