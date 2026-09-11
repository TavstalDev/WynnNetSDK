using System.Text.Json.Serialization;

namespace Tavstal.WynnNetSDK.Models.Common.Enums;

/// <summary>
/// Represents an error returned by the Wynncraft API.
/// </summary>
public class ErrorResponse
{
    /// <summary>
    /// The name of the error.
    /// </summary>
    [JsonPropertyName("error")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// A detailed message describing the error.
    /// </summary>
    [JsonPropertyName("detail")]
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// The HTTP status code of the error.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; } = -1;

    /// <summary>
    /// Additional objects related to the error, if any.
    /// </summary>
    [JsonPropertyName("objects")]
    public Dictionary<string, object>? Objects { get; set; } = null;
}
