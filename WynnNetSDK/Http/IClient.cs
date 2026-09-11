using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Defines the common operations shared by all API clients.
/// </summary>
public interface IClient
{
    /// <summary>
    /// Returns true if there are remaining requests available in the current minute.
    /// </summary>
    /// <returns>True if the client can make more requests.</returns>
    bool CanExecute();

    /// <summary>
    /// Resets the request counter so a new minute of requests can begin.
    /// </summary>
    void ResetRpm();

    /// <summary>
    /// Sends a request that returns a typed response body.
    /// </summary>
    /// <typeparam name="T">The expected response type.</typeparam>
    /// <param name="requestBase">The request to send.</param>
    /// <param name="cacheTime">How long to cache the response. Null means no caching.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A result containing the response value or an error.</returns>
    Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase,
        TimeSpan? cacheTime = null, CancellationToken cancellationToken = default) where T : class;

    /// <summary>
    /// Sends a request that does not return a response body.
    /// </summary>
    /// <param name="requestBase">The request to send.</param>
    /// <param name="cacheTime">How long to cache the result. Null means no caching.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A result indicating success or failure.</returns>
    Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase,
        TimeSpan? cacheTime = null, CancellationToken cancellationToken = default);
}
