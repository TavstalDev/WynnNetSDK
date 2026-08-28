using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player.GlobalData;

public class PlayerDataRestrictions
{
    [JsonPropertyName("mainAccess")]
    public bool MainAccess { get; set; }
    
    [JsonPropertyName("characterDataAccess")]
    public bool CharacterDataAccess { get; set; }
}