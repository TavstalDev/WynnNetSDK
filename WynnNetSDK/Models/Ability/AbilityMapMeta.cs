using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Items.Icon;

namespace Tavstal.WynnNetSDK.Models.Ability;

public class AbilityMapMeta
{
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("icon")]
    public object Icon { get; set; } = new();
    
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    public void GetIcon(out string? strIcon, out ItemIcon? objIcon)
    {
        if (Icon is string str)
        {
            strIcon = str;
            objIcon = null;
            return;
        }

        if (Icon is ItemIcon obj)
        {
            objIcon = obj;
            strIcon = null;
            return;
        }
        
        throw new Exception("Unknown icon type");
    }
}