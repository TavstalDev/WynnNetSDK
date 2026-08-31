using Tavstal.WynnNetSDK.Models.Common;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http;

public abstract class HttpClientBase : IClient
{
    protected readonly IWynnHttpClient _client;
    
    protected HttpClientBase(IWynnHttpClient client)
    {
        _client = client;
    }
    
    public async Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase, CancellationToken cancellationToken = default) where T : class
    {
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
    
    public async Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase, CancellationToken cancellationToken = default)
    {
        var response = await _client.SendAsync(requestBase, cancellationToken);
        if (!response.IsSuccessStatusCode)
            return await HandleErrorAsync<bool>(requestBase, response, cancellationToken);
        return Result<bool, ErrorResponse>.Success(true);
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