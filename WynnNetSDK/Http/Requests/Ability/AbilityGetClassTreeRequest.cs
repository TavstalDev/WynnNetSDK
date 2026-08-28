namespace Tavstal.WynnNetSDK.Http.Requests.Ability;

public class AbilityGetClassTreeRequest : HttpRequestBase
{
    public AbilityGetClassTreeRequest(string @class) 
        : base(HttpMethod.Get, $"/v3/ability/tree/{@class}")
    {
    }
}