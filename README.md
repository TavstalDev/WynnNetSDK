# WynnNetSDK

![Release (latest by date)](https://img.shields.io/github/v/release/TavstalDev/WynnNetSDK?style=plastic-square)
![Workflow Status](https://img.shields.io/github/actions/workflow/status/TavstalDev/WynnNetSDK/release.yml?branch=stable&label=build&style=plastic-square)
![License](https://img.shields.io/github/license/TavstalDev/WynnNetSDK?style=plastic-square)
![Downloads](https://img.shields.io/github/downloads/TavstalDev/WynnNetSDK/total?style=plastic-square)
![Issues](https://img.shields.io/github/issues/TavstalDev/WynnNetSDK?style=plastic-square)

**WynnNetSDK** is a C# library for .NET. It connects your .NET app to the
[Wynncraft API](https://docs.wynncraft.com/welcome). It handles the HTTP calls, JSON serialization,
retries, rate limits, and caching for you.

It targets **.NET 8**, **.NET 9**, and **.NET 10**.

---

## Features

- Covers all Wynncraft API areas: players, guilds, items, classes, maps, news, leaderboards, recipes, abilities, and search.
- Returns `Result<T, ErrorResponse>` instead of throwing exceptions.
- Retries failed requests and rate-limited requests for you.
- Optional caching with `ICacheManager`. Each endpoint has a default cache time.
- Keeps track of your requests per minute and throws `RateLimitException` when you run out.
- Supports API tokens to get higher rate limits.
- Uses source-generated JSON with `System.Text.Json`, so it is fast and trim-safe.

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

// 3. Call the API and check the result.
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

> **Tip**: this SDK needs an API token. The `WynnEnvironment` constructor rejects empty tokens.
> You can get a token from the [Account Dashboard](https://docs.wynncraft.com/authentication#creating-tokens).

---

## How the Result pattern works

Every method returns a `Result<T, ErrorResponse>`. It has three useful properties:

- `IsSuccess` — `true` when the request worked.
- `Value` — the data you asked for. Only set when `IsSuccess` is `true`.
- `Error` — the error details. Only set when `IsSuccess` is `false`.

You can check these properties directly, or use the helper methods:

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

// Option 2: use Switch when you only run actions
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

You can change how the client works with `WynnClientOptions`:

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

| Option | Type | Default | What it does |
|---|---|---|---|
| `ApplicationName` | `string?` | `null` | Name used in the `User-Agent` header. |
| `Timeout` | `TimeSpan` | 120 seconds | Request timeout. |
| `MaxResponseContentBufferSize` | `long` | 2 MB | Max size of the response content buffer. |
| `MaxConnectionsPerServer` | `int` | 10 | Max open connections per server. |
| `MaxRetries` | `int` | 3 | Number of retries for failed or rate-limited requests. |
| `RetryDelay` | `TimeSpan` | 1 second | Delay between retries. |
| `EnableCompression` | `bool` | `true` | Enables gzip/deflate compression. |
| `RetryOnRateLimit` | `bool` | `true` | Retries when the API returns `HTTP 429`. |
| `Proxy` | `IWebProxy?` | `null` | Optional HTTP proxy. |

---

## Caching

Responses are cached **only if** you give the client an `ICacheManager`. Without one, the SDK makes
a real HTTP request every time.

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

Each endpoint has a default cache time. For example, player profiles are cached for 2 minutes,
while the list of item materials is cached for 1 hour. See the
[API reference](docs/API_REFERENCE.md) for the full list.

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

> **Note**: the examples above assume you added the needed `using` statements. For example:
> `using Tavstal.WynnNetSDK.Models.Items.Enums;` and `using Tavstal.WynnNetSDK.Models.News.Enums;`.

---

## Error handling

Methods return errors instead of throwing them. The `ErrorResponse` model has four fields:

- `Name` — a short name for the error.
- `Message` — a human-readable description of the error.
- `Code` — the error code, when the API provides one.
- `Objects` — extra details about the error, when available.

Only one exception can be thrown: `RateLimitException`. It happens when you used all your requests
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

## API reference

See [docs/API_REFERENCE.md](docs/API_REFERENCE.md) for the full list of clients, methods,
parameters, and models.

---

## Contributing

See [docs/CONTRIBUTING.md](docs/CONTRIBUTING.md) for guidelines on how to help with this project.

---

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for more details.

## Contact

For issues or feature requests, use the
[GitHub issue tracker](https://github.com/TavstalDev/WynnNetSDK/issues).