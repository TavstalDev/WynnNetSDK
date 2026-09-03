using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http;

public interface IClient
{
    bool CanExecute();

    void ResetRpm();
    
    Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase,
        TimeSpan? cacheTime = null, CancellationToken cancellationToken = default) where T : class;
    
    Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase,
        TimeSpan? cacheTime = null, CancellationToken cancellationToken = default);
}