using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents the quest count for a map location.
/// </summary>
public class MapQuests
{
    /// <summary>
    /// The number of quests available at this location.
    /// </summary>
    [JsonPropertyName("quests")]
    public int Quests { get; set; }
}
