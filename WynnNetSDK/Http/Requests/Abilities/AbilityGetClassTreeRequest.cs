using Tavstal.WynnNetSDK.Models.Abilities.Responses;
using Tavstal.WynnNetSDK.Models.Classes;

namespace Tavstal.WynnNetSDK.Http.Requests.Abilities;

public class AbilityGetClassTreeRequest : HttpRequestBase<AbilityTreeResult>
{
    public AbilityGetClassTreeRequest(EClass @class) 
        : base(HttpMethod.Get, $"/v3/ability/tree/{@class}")
    {
    }
}