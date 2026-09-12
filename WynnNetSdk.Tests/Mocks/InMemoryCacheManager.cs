using Tavstal.WynnNetSDK.Caching;

namespace Tavstal.WynnNetSdk.Tests.Mocks;

/// <summary>
/// A simple in-memory <see cref="ICacheManager"/> for tests. It also counts calls and lets tests
/// expire all entries on demand.
/// </summary>
public class InMemoryCacheManager : ICacheManager
{
    private readonly Dictionary<string, (object? Value, DateTime ValidUntilUtc)> _items = [];
    // ReSharper disable once ChangeFieldTypeToSystemThreadingLock - .NET 8 compatibility
    private readonly object _lock = new();

    public int GetCalls { get; private set; }
    public int AddCalls { get; private set; }
    public int RemoveCalls { get; private set; }

    public Task AddAsync<T>(string key, T value, DateTime validUntilUtc, CancellationToken cancellationToken = default)
    {
        lock (_lock)
        {
            _items[key] = (value, validUntilUtc);
            AddCalls++;
        }
        return Task.CompletedTask;
    }

    public Task RemoveAsync(string key, CancellationToken cancellationToken = default)
    {
        lock (_lock)
        {
            _items.Remove(key);
            RemoveCalls++;
        }
        return Task.CompletedTask;
    }

    public Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default)
    {
        lock (_lock)
        {
            GetCalls++;
            if (_items.TryGetValue(key, out var entry) && entry.ValidUntilUtc > DateTime.UtcNow)
                return Task.FromResult((T?)entry.Value);
            return Task.FromResult<T?>(default);
        }
    }

    /// <summary>
    /// Returns the stored entry for the given key without checking expiry.
    /// </summary>
    public (object? Value, DateTime ValidUntilUtc)? GetStored(string key)
    {
        lock (_lock)
        {
            return _items.TryGetValue(key, out var entry) ? entry : null;
        }
    }

    /// <summary>
    /// Marks every stored entry as expired so the next lookup misses the cache.
    /// </summary>
    public void ExpireAll()
    {
        lock (_lock)
        {
            var keys = _items.Keys.ToList();
            foreach (var key in keys)
                _items[key] = (_items[key].Value, DateTime.UtcNow.AddSeconds(-1));
        }
    }
}