using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSDK.Http;

/// <summary>
/// Base class for all HTTP requests sent to the Wynncraft API.
/// </summary>
public abstract class HttpRequestBase
{
    /// <summary>
    /// The HTTP method used for this request (GET, POST, etc.).
    /// </summary>
    public HttpMethod Method { get; }

    /// <summary>
    /// The URL this request will be sent to.
    /// </summary>
    public Uri RequestUri { get; protected set; }

    /// <summary>
    /// Custom headers added to the request.
    /// </summary>
    public Dictionary<string, string> Headers { get; protected set; } = [];

    /// <summary>
    /// The body content of the request, or null for requests without a body.
    /// </summary>
    public HttpContent? Content { get; set; }

    /// <summary>
    /// The type of the request body content, or null when there is no body.
    /// </summary>
    public Type? ContentType { get; protected set; }

    /// <summary>
    /// The JSON type info used to serialize the request body.
    /// </summary>
    public JsonTypeInfo? ContentJsonTypeInfo { get; protected set; }

    /// <summary>
    /// Creates a new request with the given method, URL, and optional body content.
    /// </summary>
    /// <param name="method">The HTTP method used for the request.</param>
    /// <param name="url">The URL the request is sent to.</param>
    /// <param name="content">The request body object, or null when there is no body.</param>
    protected HttpRequestBase(HttpMethod method, string url, object? content = null)
    {
        Method = method;
        RequestUri = new Uri(url, UriKind.Relative);

        if (content != null)
        {
            ContentType = content.GetType();
            ContentJsonTypeInfo = WynnSdkJsonContext.Default.GetTypeInfo(ContentType);
            if (ContentJsonTypeInfo == null)
                throw new InvalidOperationException($"Type {ContentType.Name} is not registered in the provided JsonSerializerContext.");
            Content = JsonContent.Create(content, ContentJsonTypeInfo);
        }
    }

    /// <summary>
    /// Reads and deserializes the error response body from the server.
    /// </summary>
    /// <param name="response">The HTTP response to read from.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The deserialized error, or null if parsing failed.</returns>
    public async Task<ErrorResponse?> GetErrorResponseAsync(HttpResponseMessage response,
        CancellationToken cancellationToken = default)
    {
        try
        {
            return await response.Content.ReadFromJsonAsync(WynnSdkJsonContext.Default.ErrorResponse,
                cancellationToken: cancellationToken);
        }
        catch (JsonException)
        {
            return null;
        }
    }

    /// <summary>
    /// Converts this request into an <see cref="HttpRequestMessage"/> that can be sent by an <see cref="HttpClient"/>.
    /// </summary>
    /// <returns>A new <see cref="HttpRequestMessage"/>.</returns>
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

    /// <summary>
    /// Returns a string that uniquely identifies this request. Used as the cache key.
    /// </summary>
    /// <returns>A unique key built from the method, URL, and body.</returns>
    public string GetKey()
    {
        if (ContentJsonTypeInfo != null)
            return $"{Method}:{RequestUri}:{JsonSerializer.Serialize(Content, ContentJsonTypeInfo!)}";
        return $"{Method}:{RequestUri}";
    }
}

/// <summary>
/// Base class for HTTP requests that return a typed response body.
/// </summary>
/// <typeparam name="T">The expected response type.</typeparam>
public abstract class HttpRequestBase<T> : HttpRequestBase where T : class
{
    /// <summary>
    /// Creates a new request with the given method and URL.
    /// </summary>
    /// <param name="method">The HTTP method.</param>
    /// <param name="url">The request URL.</param>
    protected HttpRequestBase(HttpMethod method, string url)
        : base(method, url) { }

    /// <summary>
    /// Creates a new request with a method, URL, and body content.
    /// </summary>
    /// <param name="method">The HTTP method.</param>
    /// <param name="url">The request URL.</param>
    /// <param name="content">The request body object to serialize.</param>
    protected HttpRequestBase(HttpMethod method, string url, object? content = null)
        : base(method, url, content) { }

    /// <summary>
    /// Reads and deserializes the response body into type <typeparamref name="T"/>.
    /// </summary>
    /// <param name="response">The HTTP response to read from.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The deserialized response, or null if parsing failed.</returns>
    public async Task<T?> GetResponseBodyAsync(HttpResponseMessage response, CancellationToken cancellationToken = default)
    {
        var typeInfo = (JsonTypeInfo<T>?)WynnSdkJsonContext.Default.GetTypeInfo(typeof(T));
        if (typeInfo == null)
            throw new InvalidOperationException($"Type {typeof(T).Name} is not registered in the provided JsonSerializerContext.");
        return await response.Content.ReadFromJsonAsync(typeInfo, cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Reads and deserializes the response body using the given JSON type info.
    /// </summary>
    /// <param name="response">The HTTP response to read from.</param>
    /// <param name="jsonTypeInfo">The JSON type info to use for deserialization.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The deserialized response, or null if parsing failed.</returns>
    public async Task<T?> GetResponseBodyAsync(HttpResponseMessage response, JsonTypeInfo<T> jsonTypeInfo, CancellationToken cancellationToken = default) =>
        await response.Content.ReadFromJsonAsync(jsonTypeInfo, cancellationToken: cancellationToken);
}
