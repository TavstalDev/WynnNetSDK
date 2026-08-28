namespace Tavstal.WynnNetSDK.Http.Requests.Classes;

public class ClassesGetRequest : HttpRequestBase
{
    public ClassesGetRequest(string @class) 
        : base(HttpMethod.Get, $"/v3/classes/{@class}")
    {
    }
}