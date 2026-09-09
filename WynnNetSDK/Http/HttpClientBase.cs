using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Exceptions;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Base class for all Wynncraft API clients. Handles caching, rate limiting, and error responses.
/// </summary>
public abstract class HttpClientBase : IClient
{
    protected readonly IWynnHttpClient _client;
    private readonly ICacheManager? _cacheManager;
    private int _remainingRpm = 120;
    private DateTime _nextReset;
    
    protected HttpClientBase(IWynnHttpClient client, ICacheManager? cacheManager = null)
    {
        _client = client;
        _cacheManager = cacheManager;
        _nextReset = DateTime.UtcNow.AddMinutes(1);
    }

    /// <summary>
    /// Returns true if there are remaining requests available in the current minute.
    /// </summary>
    /// <returns>True if the client can still make requests.</returns>
    public bool CanExecute() =>
        _remainingRpm > 0;

    /// <summary>
    /// Resets the request counter so a new minute of requests can begin.
    /// </summary>
    public void ResetRpm()
    {
        _remainingRpm = 120;
        _nextReset = DateTime.UtcNow.AddMinutes(1);
    }

    /// <summary>
    /// Sends a request that returns a typed response body. Uses the cache when available.
    /// </summary>
    /// <typeparam name="T">The expected response type.</typeparam>
    /// <param name="requestBase">The request to send.</param>
    /// <param name="cacheTime">How long to cache the response. Null means no caching.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A result containing the response value or an error.</returns>
    public async Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase, TimeSpan? cacheTime = null, CancellationToken cancellationToken = default) where T : class
    {
        try
        {
            string cacheKey = requestBase.GetKey();
            T? cachedResult = null;
            if (_cacheManager != null)
                cachedResult = await _cacheManager.GetAsync<T>(cacheKey, cancellationToken);
            if (cachedResult != null)
                return Result<T, ErrorResponse>.Success(cachedResult);
            
            if (!CanExecute())
                throw new RateLimitException
                {
                    AvailableAt = _nextReset
                };
            
            var response = await _client.SendAsync(requestBase, cancellationToken);
            if (!response.IsSuccessStatusCode)
                return await HandleErrorAsync<T>(requestBase, response, cancellationToken);

            try
            {
                var responseBody = await requestBase.GetResponseBodyAsync(response, cancellationToken);
                if (responseBody == null)
                    return Result<T, ErrorResponse>.Failure(new ErrorResponse
                    {
                        Name = "Serialization error.",
                        Message = "Failed to deserialize success response body."
                    });

                if (_cacheManager != null && cacheTime != null)
                {
                    await _cacheManager.AddAsync(cacheKey, responseBody, DateTime.UtcNow.Add(cacheTime.Value), cancellationToken);
                }
                
                return Result<T, ErrorResponse>.Success(responseBody);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception ex)
            {
                return Result<T, ErrorResponse>.Failure(new ErrorResponse
                {
                    Name = "Unexpected error occurred while deserializing success response body.",
                    Message = ex.Message,
                });
            }
        }
        finally
        {
            if (_remainingRpm > 0)
                _remainingRpm--;
        }
    }
    
    /// <summary>
    /// Sends a request that does not return a response body.
    /// </summary>
    /// <param name="requestBase">The request to send.</param>
    /// <param name="cacheTime">How long to cache the result. Null means no caching.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>A result indicating success or failure.</returns>
    public async Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase, TimeSpan? cacheTime = null,  CancellationToken cancellationToken = default)
    {
        try
        {
            if (!CanExecute())
                throw new RateLimitException
                {
                    AvailableAt = _nextReset
                };

            var response = await _client.SendAsync(requestBase, cancellationToken);
            if (!response.IsSuccessStatusCode)
                return await HandleErrorAsync<bool>(requestBase, response, cancellationToken);
            return Result<bool, ErrorResponse>.Success(true);
        }
        finally
        {
            if (_remainingRpm > 0)
                _remainingRpm--;
        }
    }
    
    private async Task<Result<T, ErrorResponse>> HandleErrorAsync<T>(HttpRequestBase requestBase, HttpResponseMessage response, CancellationToken cancellationToken)
    {
        try
        {
            var errorResponse = await requestBase.GetErrorResponseAsync(response, cancellationToken);
            if (errorResponse == null)
                return Result<T, ErrorResponse>.Failure(new ErrorResponse
                {
                    Name = "Serialization error.",
                    Message = "Failed to parse api error response, the request probably did not reach api server."
                });

            return Result<T, ErrorResponse>.Failure(errorResponse);
        }
        catch (OperationCanceledException)
        {
            throw;
        }
        catch (HttpRequestException ex)
        {
            return Result<T, ErrorResponse>.Failure(new ErrorResponse
            {
                Name = $"HTTP Error, Status Code: {ex.StatusCode ?? 0}",
                Message = ex.Message,
            });
        }
        catch (Exception ex)
        {
            return Result<T, ErrorResponse>.Failure(new ErrorResponse
            {
                Name = "Unexpected error occurred while deserializing error response.",
                Message = ex.Message,
            });
        }
    }
}