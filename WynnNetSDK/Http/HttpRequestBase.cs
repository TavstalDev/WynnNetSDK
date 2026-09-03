using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Http;

public abstract class HttpRequestBase
{
    public HttpMethod Method { get; }
    
    public Uri RequestUri { get; protected set; }
    
    public Dictionary<string, string> Headers { get; protected set; } = [];
    
    public HttpContent? Content { get; set; }
    
    public Type? ContentType { get; protected set; }
    public JsonTypeInfo? ContentJsonTypeInfo { get; protected set; }
    
    protected HttpRequestBase(HttpMethod method, string url, object? content = null)
    {
        Method = method;
        RequestUri = new Uri(url, UriKind.Relative);

        if (content != null)
        {
            ContentType = content.GetType();
            ContentJsonTypeInfo = WynnNetSDKJsonContext.Default.GetTypeInfo(ContentType);
            if (ContentJsonTypeInfo== null)
                throw new InvalidOperationException($"Type {ContentType.Name} is not registered in the provided JsonSerializerContext.");
            Content = JsonContent.Create(content, ContentJsonTypeInfo);
        }
    }
    
    public async Task<ErrorResponse?> GetErrorResponseAsync(HttpResponseMessage response,
        CancellationToken cancellationToken = default)
    {
        try
        {
            return await response.Content.ReadFromJsonAsync(WynnNetSDKJsonContext.Default.ErrorResponse,
                cancellationToken: cancellationToken);
        }
        catch (JsonException)
        {
            return null;
        }
    }
    
    public HttpRequestMessage ToHttpRequestMessage()
    {
        var requestMessage = new HttpRequestMessage();
        requestMessage.Method = Method;
        requestMessage.RequestUri = RequestUri;
        requestMessage.Content = Content;
        foreach (var header in Headers)
            requestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value);
        return requestMessage;
    }
    
    public string GetKey()
    {
        if (ContentJsonTypeInfo != null)
            return  $"{Method}:{RequestUri}:{JsonSerializer.Serialize(Content, ContentJsonTypeInfo!)}";
        return $"{Method}:{RequestUri}";
    }
}

public abstract class HttpRequestBase<T> : HttpRequestBase where T : class
{
    protected HttpRequestBase(HttpMethod method, string url)
        : base(method, url) { }
    
    protected HttpRequestBase(HttpMethod method, string url, object? content = null)
        : base(method, url, content) { }
    
    public async Task<T?> GetResponseBodyAsync(HttpResponseMessage response, CancellationToken cancellationToken = default)
    {
        var typeInfo = (JsonTypeInfo<T>?)WynnNetSDKJsonContext.Default.GetTypeInfo(typeof(T));
        if (typeInfo == null)
            throw new InvalidOperationException($"Type {typeof(T).Name} is not registered in the provided JsonSerializerContext.");
        return await response.Content.ReadFromJsonAsync(typeInfo, cancellationToken: cancellationToken);
    }
    
    public async Task<T?> GetResponseBodyAsync(HttpResponseMessage response, JsonTypeInfo<T> jsonTypeInfo, CancellationToken cancellationToken = default) => 
        await response.Content.ReadFromJsonAsync(jsonTypeInfo, cancellationToken: cancellationToken);
}