using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Classes;

public class ClassesListRequest : HttpRequestBase<Dictionary<string, Class>>
{
    public ClassesListRequest() 
        : base(HttpMethod.Get, "/v3/classes")
    {
    }
}