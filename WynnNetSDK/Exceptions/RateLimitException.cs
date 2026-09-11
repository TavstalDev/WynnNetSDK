namespace Tavstal.WynnNetSDK.Exceptions;

/// <summary>
/// Thrown when the SDK detects that the API rate limit has been reached.
/// </summary>
public class RateLimitException : Exception
{
    /// <summary>
    /// The UTC time when new requests will be available again.
    /// </summary>
    public DateTime AvailableAt { get; set; }
}
