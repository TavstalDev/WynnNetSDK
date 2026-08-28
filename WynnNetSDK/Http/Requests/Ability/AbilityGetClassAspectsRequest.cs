namespace Tavstal.WynnNetSDK.Http.Requests.Ability;

public class AbilityGetClassAspectsRequest : HttpRequestBase
{
    public AbilityGetClassAspectsRequest(string @class) 
        : base(HttpMethod.Get, $"/v3/aspects/{@class}")
    {
    }
}