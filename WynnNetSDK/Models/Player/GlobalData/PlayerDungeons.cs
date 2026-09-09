using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

/// <summary>
/// Represents a player's dungeon or raid completion statistics.
/// </summary>
public class PlayerDungeons
{
    /// <summary>
    /// The total number of completions.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; set; }
    
    /// <summary>
    /// A dictionary of individual dungeon or raid names and their completion counts.
    /// </summary>
    [JsonPropertyName("list")]
    public Dictionary<string, int> List { get; set; } = new ();
}