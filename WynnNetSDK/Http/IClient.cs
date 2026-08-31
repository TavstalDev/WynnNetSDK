using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSDK.Http;

public interface IClient
{
    Task<Result<T, ErrorResponse>> ExecuteAsync<T>(HttpRequestBase<T> requestBase,
        CancellationToken cancellationToken = default) where T : class;
    
    Task<Result<bool, ErrorResponse>> ExecuteAsync(HttpRequestBase requestBase,
        CancellationToken cancellationToken = default);
}