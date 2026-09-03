namespace Tavstal.WynnNetSDK.Caching;

public interface ICacheManager
{
    Task AddAsync<T>(string key, T value, DateTime validUntilUtc, CancellationToken cancellationToken = default);
    
    Task RemoveAsync(string key, CancellationToken cancellationToken = default);
    
    Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default);
}