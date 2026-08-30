using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Models.Abilities.Responses;

public class AbilityTreeResult
{
    [JsonPropertyName("archtypes")]
    public Dictionary<string, Archtype> Archtypes { get; set; } = [];
    
    [JsonPropertyName("pages")]
    public Dictionary<string, Dictionary<string, Ability>> Pages {  get; set; } = [];
}