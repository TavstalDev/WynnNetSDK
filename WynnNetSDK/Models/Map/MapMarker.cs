using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Map;

/// <summary>
/// Represents a custom marker on the Wynncraft map.
/// </summary>
public class MapMarker
{
    /// <summary>
    /// The name of the marker.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// The icon used to display the marker.
    /// </summary>
    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;
    
    /// <summary>
    /// The X coordinate of the marker.
    /// </summary>
    [JsonPropertyName("x")]
    public string X { get; set; } = string.Empty;
    
    /// <summary>
    /// The Y coordinate of the marker.
    /// </summary>
    [JsonPropertyName("y")]
    public string Y { get; set; } = string.Empty;
    
    /// <summary>
    /// The Z coordinate of the marker.
    /// </summary>
    [JsonPropertyName("z")]
    public string Z { get; set; } = string.Empty;
}