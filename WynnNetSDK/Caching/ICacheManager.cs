namespace Tavstal.WynnNetSDK.Caching;

/// <summary>
/// Defines a cache that the SDK can use to store API responses.
/// </summary>
public interface ICacheManager
{
    /// <summary>
    /// Stores a value in the cache until the specified time.
    /// </summary>
    /// <typeparam name="T">The type of the value to store.</typeparam>
    /// <param name="key">The cache key.</param>
    /// <param name="value">The value to store.</param>
    /// <param name="validUntilUtc">The UTC time when the cached value expires.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    Task AddAsync<T>(string key, T value, DateTime validUntilUtc, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Removes a value from the cache.
    /// </summary>
    /// <param name="key">The cache key to remove.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    Task RemoveAsync(string key, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Gets a cached value by its key. Returns null when the value is missing or expired.
    /// </summary>
    /// <typeparam name="T">The expected type of the cached value.</typeparam>
    /// <param name="key">The cache key.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The cached value, or null if not found or expired.</returns>
    Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default);
}