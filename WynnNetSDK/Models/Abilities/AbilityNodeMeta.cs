using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;
using Tavstal.WynnNetSDK.Serialization;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Abilities;

/// <summary>
/// Contains metadata for an ability node in the ability tree.
/// </summary>
public class AbilityNodeMeta
{
    /// <summary>
    /// The page number where this node appears in the ability tree.
    /// </summary>
    [JsonPropertyName("page")]
    public int Page { get; set; }

    /// <summary>
    /// The raw icon data for this ability node.
    /// </summary>
    [Obsolete("Please use GetIcon().")]
    [JsonPropertyName("icon")]
    public JsonElement? Icon { get; set; }

    /// <summary>
    /// The unique identifier of this ability node.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Parses the icon data into either a string or an ItemIcon object.
    /// </summary>
    public void GetIcon(out string? strIcon, out ItemIcon? objIcon)
    {
        if (Icon == null)
        {
            strIcon = null;
            objIcon = null;
            return;
        }

        var v = Icon.Value;
        switch (v.ValueKind)
        {
            case JsonValueKind.String:
            {
                strIcon = v.GetRawText();
                objIcon = null;
                return;
            }
            case JsonValueKind.Object:
            {
                var obj = v.Deserialize(WynnSdkJsonContext.Default.ItemIcon);
                objIcon = obj;
                strIcon = null;
                return;
            }
        }

        throw new Exception("Unknown icon type");
    }
}
