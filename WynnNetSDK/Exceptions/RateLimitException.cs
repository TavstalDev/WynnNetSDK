namespace Tavstal.WynnNetSDK.Exceptions;

public class RateLimitException : Exception
{
    public DateTime AvailableAt { get; set; }
}