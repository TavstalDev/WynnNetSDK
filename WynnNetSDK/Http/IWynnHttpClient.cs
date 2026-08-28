namespace Tavstal.WynnNetSDK.Http;

public interface IWynnHttpClient
{
    Task<HttpResponseMessage> SendAsync(HttpRequestBase request, CancellationToken cancellationToken = default);
}