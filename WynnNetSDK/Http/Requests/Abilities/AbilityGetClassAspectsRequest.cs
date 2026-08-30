using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Abilities;

public class AbilityGetClassAspectsRequest : HttpRequestBase<List<Aspect>>
{
    public AbilityGetClassAspectsRequest(EClass @class) 
        : base(HttpMethod.Get, $"/v3/aspects/{@class}")
    {
    }
}