# WynnNetSDK

**WynnNetSDK** is a modern C# library for .NET. It helps you connect your .NET application to the
[Wynncraft API](https://docs.wynncraft.com/welcome). It handles the HTTP calls, JSON serialization, retries,
rate limits, and caching for you, so you can focus on your own code.

It is built for **.NET 8**, **.NET 9**, and **.NET 10**.

---

## Features

- **All Wynncraft endpoints** in one place: players, guilds, items, classes, maps, news, leaderboards, recipes, abilities and search.
- **Result pattern**: every method returns a `Result<T, ErrorResponse>` instead of throwing exceptions.
- **Built-in retry logic**: the SDK retries failed requests and rate-limited requests automatically.
- **Response caching**: optional `ICacheManager` with built-in default cache durations per endpoint.
- **Rate limit guard**: the SDK tracks the remaining requests per minute (RPM) and throws `RateLimitException` when you hit the limit.
- **Token support**: pass your Wynncraft API token to increase your rate limits.
- **Source-generated JSON**: fast and trim-safe serialization with `System.Text.Json`.

---

## Installation

### NuGet

```
dotnet add package WynnNetSDK
```

### From source

```bash
git clone https://github.com/TavstalDev/WynnNetSDK.git
dotnet build WynnNetSDK/WynnNetSDK.csproj
```

---

## Quick start

```csharp
using Tavstal.WynnNetSDK.Http;

// 1. Create the Wynncraft environment with your API token.
var environment = new WynnEnvironment(token: "YOUR_API_TOKEN");

// 2. Create the HTTP client.
using var client = new WynnHttpClient(environment);

// 3. Call the API and check the Result.
var result = await client.Player.GetProfileAsync("Tavstal");
if (result.IsSuccess)
{
    Console.WriteLine($"Username: {result.Value.Username}");
}
else
{
    Console.WriteLine($"Error: {result.Error.Message}");
}
```

> **Tip**: This SDK requires an API token (the `WynnEnvironment` constructor rejects empty tokens). You can request a token from [Account Dashboard](https://docs.wynncraft.com/authentication#creating-tokens).

---

## How the Result pattern works

Every method returns a `Result<T, ErrorResponse>`. It has two important properties:

- `IsSuccess` — `true` when the request worked, `false` when it failed.
- `Value` — the data you asked for (only available when `IsSuccess` is `true`).
- `Error` — the error details (only available when `IsSuccess` is `false`).

You can read these properties directly, or use the helper methods:

```csharp
var result = await client.Player.GetProfileAsync("Tavstal");

// Option 1: check the flags
if (result.IsSuccess)
{
    var player = result.Value;
}
else
{
    var error = result.Error;
}

// Option 2: use Switch for actions that return void
result.Switch(
    onSuccess: player => Console.WriteLine($"Hello {player.Username}!"),
    onFailure: error => Console.WriteLine($"Something went wrong: {error.Message}")
);

// Option 3: use Match when you want a value back
var message = result.Match(
    onSuccess: player => $"Hello {player.Username}!",
    onFailure: error => $"Something went wrong: {error.Message}"
);
```

---

## Configuration

You can customize the client with `WynnClientOptions`:

```csharp
var options = new WynnClientOptions
{
    ApplicationName = "MyApp/WynnNetSDK",   // custom User-Agent header
    Timeout = TimeSpan.FromSeconds(60),
    MaxRetries = 5,                          // how many times to retry
    RetryDelay = TimeSpan.FromMilliseconds(500),
    EnableCompression = true,                // gzip / deflate
    RetryOnRateLimit = true,                 // retry on HTTP 429
    MaxConnectionsPerServer = 10,
    MaxResponseContentBufferSize = 1024 * 1024 * 4
};

using var client = new WynnHttpClient(new WynnEnvironment("YOUR_API_TOKEN"), options);
```

### All options

| Option                         | Type         | Default     | What it does                                           |
|--------------------------------|--------------|-------------|--------------------------------------------------------|
| `ApplicationName`              | `string?`    | `null`      | Name used in the `User-Agent` header.                  |
| `Timeout`                      | `TimeSpan`   | 120 seconds | Request timeout.                                       |
| `MaxResponseContentBufferSize` | `long`       | 2 MB        | Max size of the response content buffer.               |
| `MaxConnectionsPerServer`      | `int`        | 10          | Max open connections per server.                       |
| `MaxRetries`                   | `int`        | 3           | Number of retries for failed or rate-limited requests. |
| `RetryDelay`                   | `TimeSpan`   | 1 second    | Delay between retries.                                 |
| `EnableCompression`            | `bool`       | `true`      | Enables gzip/deflate compression.                      |
| `RetryOnRateLimit`             | `bool`       | `true`      | Retries when the API returns `HTTP 429`.               |
| `Proxy`                        | `IWebProxy?` | `null`      | Optional HTTP proxy.                                   |

---

## Caching

Responses are cached **only if** you provide an `ICacheManager`. Without one, the SDK makes a real
HTTP request every time.

To enable caching, implement the `ICacheManager` interface:

```csharp
using Tavstal.WynnNetSDK.Caching;

public class MemoryCacheManager : ICacheManager
{
    private readonly Dictionary<string, (object Value, DateTime ValidUntilUtc)> _items = new();

    public Task AddAsync<T>(string key, T value, DateTime validUntilUtc, CancellationToken cancellationToken = default)
    {
        _items[key] = (value!, validUntilUtc);
        return Task.CompletedTask;
    }

    public Task RemoveAsync(string key, CancellationToken cancellationToken = default)
    {
        _items.Remove(key);
        return Task.CompletedTask;
    }

    public Task<T?> GetAsync<T>(string key, CancellationToken cancellationToken = default)
    {
        if (_items.TryGetValue(key, out var entry) && entry.ValidUntilUtc > DateTime.UtcNow)
            return Task.FromResult((T?)entry.Value);
        return Task.FromResult<T?>(default);
    }
}
```

Then pass it to the client:

```csharp
var cache = new MemoryCacheManager();
using var client = new WynnHttpClient(new WynnEnvironment("YOUR_API_TOKEN"), cacheManager: cache);
```

Each endpoint has a built-in default cache duration. For example, player profiles are cached for
2 minutes, while the list of item materials is cached for 1 hour. See the
[API reference](https://github.com/TavstalDev/WynnNetSDK/blob/master/docs/API_REFERENCE.md) for the full list.

---

## More examples

### Player

```csharp
var online = await client.Player.ListOnlineAsync(server: "WC1");
if (online.IsSuccess)
    Console.WriteLine($"Players online: {online.Value.Total}");
```

### Guild

```csharp
var guild = await client.Guild.GetByNameAsync("Tavstal");
if (guild.IsSuccess)
    Console.WriteLine($"Guild level: {guild.Value.Level}");
```

### Items

```csharp
var items = await client.Items.ListAsync(page: 2);
if (items.IsSuccess)
    Console.WriteLine($"Found {items.Value.Results.Count} items");
```

```csharp
var body = new ItemSearchRequestBody
{
    Query = "Ragni",
    Tier = new List<ETier> { ETier.MYTHIC, ETier.FABLED },
};

var search = await client.Items.SearchAsync(body);
```

### News

```csharp
var articles = await client.News.ListAsync(EArticleType.BLOG);
if (articles.IsSuccess)
    foreach (var article in articles.Value.Results.Values)
        Console.WriteLine(article.Title);
```

> **Note**: the classes above assume you added the `using` statements for the models. For example:
> `using Tavstal.WynnNetSDK.Models.Items.Enums;` and `using Tavstal.WynnNetSDK.Models.News.Enums;`.

---

## Error handling

Methods return errors instead of throwing. The `ErrorResponse` model has four fields:

- `Name` — a short name for the error.
- `Message` — a human-readable description of the error.
- `Code` — the error code, when the API provides one.
- `Objects` — extra details about the error, when available.

One exception can be thrown: `RateLimitException`, when the SDK detects you used all your requests
for the current minute. It has an `AvailableAt` property that tells you when the limit resets.

```csharp
try
{
    var result = await client.Player.GetProfileAsync("Tavstal");
}
catch (RateLimitException ex)
{
    Console.WriteLine($"Out of requests. New requests available at: {ex.AvailableAt}");
}
```

---

## License

This project is licensed under the **MIT License**. See the [LICENSE](https://github.com/TavstalDev/WynnNetSDK/blob/master/LICENSE) file for more details.

## Contact

For issues or feature requests, please use the [GitHub issue tracker](https://github.com/TavstalDev/WynnNetSDK/issues).