namespace Tavstal.WynnNetSDK.Http.Requests.Classes;

public class ClassesListRequest : HttpRequestBase
{
    public ClassesListRequest() 
        : base(HttpMethod.Get, "/v3/classes")
    {
    }
}