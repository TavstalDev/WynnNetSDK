using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Tavstal.WynnNetSDK.Caching;
using Tavstal.WynnNetSDK.Http;
using Tavstal.WynnNetSDK.Serialization;
using Tavstal.WynnNetSdk.Tests.Mocks;

namespace Tavstal.WynnNetSdk.Tests.Helpers;

public static class FakeHttpHelpers
{
    public static IWynnHttpClient CreateClient(Func<HttpRequestMessage, HttpResponseMessage> responder,
        WynnClientOptions? options = null, ICacheManager? cacheManager = null)
    {
        var mockHandler = new MockHttpMessageHandler((request, _) => Task.FromResult(responder(request)));
        return new WynnHttpClient(new WynnEnvironment("test"), new HttpClient(mockHandler), cacheManager, options);
    }

    public static Task<T?> ReadJsonAsync<T>(this HttpContent content, CancellationToken cancellationToken = default)
    {
        var typeInfo = (JsonTypeInfo<T>?)WynnSdkJsonContext.Default.GetTypeInfo(typeof(T));
        if (typeInfo == null)
            throw new InvalidOperationException($"Type {typeof(T).Name} is not registered in the provided JsonSerializerContext.");
        return content.ReadFromJsonAsync(typeInfo, cancellationToken);
    }

    public static T? DeserializeJson<T>(this string json)
    {
        var typeInfo = (JsonTypeInfo<T>?)WynnSdkJsonContext.Default.GetTypeInfo(typeof(T));
        if (typeInfo == null)
            throw new InvalidOperationException($"Type {typeof(T).Name} is not registered in the provided JsonSerializerContext.");
        return JsonSerializer.Deserialize(json, typeInfo);
    }
}
