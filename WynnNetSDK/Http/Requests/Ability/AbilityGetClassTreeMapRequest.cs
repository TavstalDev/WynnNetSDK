namespace Tavstal.WynnNetSDK.Http.Requests.Ability;

public class AbilityGetClassTreeMapRequest : HttpRequestBase
{
    public AbilityGetClassTreeMapRequest(string @class) 
        : base(HttpMethod.Get, $"/v3/ability/map/{@class}")
    {
    }
}