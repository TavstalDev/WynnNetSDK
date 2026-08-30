using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Abilities;

public class AbilityGetClassTreeMapRequest : HttpRequestBase<Dictionary<string, List<AbilityNode>>>
{
    public AbilityGetClassTreeMapRequest(EClass @class) 
        : base(HttpMethod.Get, $"/v3/ability/map/{@class}")
    {
    }
}