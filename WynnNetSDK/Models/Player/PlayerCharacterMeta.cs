using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Player;

public class PlayerCharacterMeta
{
    [JsonPropertyName("died")]
    public bool? Died { get; set; }
}