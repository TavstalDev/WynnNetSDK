using System.Text.Json;
using System.Text.Json.Serialization;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Items.Sets;

/// <summary>
/// Represents the bonuses granted by wearing multiple items from the same set.
/// </summary>
public class ItemSetBonus
{
    /// <summary>
    /// The list of major IDs granted by this set bonus.
    /// </summary>
    [JsonPropertyName("major")]
    public List<string> Major { get; set; } = [];

    /// <summary>
    /// The minor ID bonuses as raw JSON elements.
    /// </summary>
    [Obsolete("Please use GetMinor() instead.")]
    [JsonPropertyName("minor")]
    public Dictionary<string, JsonElement> Minor { get; set; } = [];

    /// <summary>
    /// Gets the minor ID bonuses as a dictionary of string values.
    /// </summary>
    /// <returns>A dictionary of minor ID names and their string values.</returns>
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
