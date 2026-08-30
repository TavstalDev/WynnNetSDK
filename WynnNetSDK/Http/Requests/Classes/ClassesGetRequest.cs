using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Classes;

public class ClassesGetRequest : HttpRequestBase<ClassDetail>
{
    public ClassesGetRequest(EClass @class) 
        : base(HttpMethod.Get, $"/v3/classes/{@class}")
    {
    }
}