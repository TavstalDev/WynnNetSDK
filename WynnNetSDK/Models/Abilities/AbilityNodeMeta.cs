using System.Text.Json;
using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;
using Tavstal.WynnNetSDK.Serialization;
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavstal.WynnNetSDK.Models.Abilities;

public class AbilityNodeMeta
{
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("icon")]
    [Obsolete("Please use GetIcon().")]
    public JsonElement? Icon { get; set; }
    
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
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
                var obj = v.Deserialize(WynnNetSDKJsonContext.Default.ItemIcon);
                objIcon = obj;
                strIcon = null;
                return;
            }
        }
        
        throw new Exception("Unknown icon type");
    }
}