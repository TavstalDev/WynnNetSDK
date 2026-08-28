namespace Tavstal.WynnNetSDK.Http.Clients;

public class NewsClient : HttpClientBase
{
    public NewsClient(IWynnHttpClient client) : base(client)
    {
    }
}