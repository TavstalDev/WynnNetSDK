using Tavstal.WynnNetSDK.Http.Requests.Items;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Http.Requests.Player;
using Tavstal.WynnNetSDK.Models.Common.Enums;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class HttpRequestTests
{
    [Fact(DisplayName = "N/A - Profile request builds the expected URL")]
    public void ProfileUri()
        => new PlayerGetProfileRequest("Nepmia").RequestUri.ToString().Should().Be("/v3/player/Nepmia");

    [Fact(DisplayName = "N/A - Online players request builds a query string")]
    public void OnlinePlayersUri_WithQuery()
        => new PlayerListOnlineRequest(EIdentifier.NAME, "WC1").RequestUri.ToString()
            .Should().Be("/v3/player?identifier=NAME&server=WC1");

    [Fact(DisplayName = "N/A - Online players request has no query string without filters")]
    public void OnlinePlayersUri_WithoutFilters()
        => new PlayerListOnlineRequest(null, (string?)null).RequestUri.ToString().Should().Be("/v3/player");

    [Fact(DisplayName = "N/A - Online players request supports numeric server overload")]
    public void OnlinePlayersUri_WithNumericServer()
        => new PlayerListOnlineRequest(EIdentifier.UUID, 5).RequestUri.ToString()
            .Should().Be("/v3/player?identifier=UUID&server=5");

    [Fact(DisplayName = "N/A - Cache key distinguishes URL parameters")]
    public void GetKey_DistinguishesUrlParameters()
    {
        new PlayerGetProfileRequest("A").GetKey().Should().NotBe(new PlayerGetProfileRequest("B").GetKey());
        new PlayerGetProfileRequest("A").GetKey().Should().Be(new PlayerGetProfileRequest("A").GetKey());
    }

    [Fact(DisplayName = "N/A - Cache key distinguishes request bodies")]
    public void GetKey_DistinguishesBodies()
    {
        var ragni = new ItemsSearchRequest(new ItemSearchRequestBody { Query = "Ragni" });
        var selchar = new ItemsSearchRequest(new ItemSearchRequestBody { Query = "Selchar" });
        var ragniAgain = new ItemsSearchRequest(new ItemSearchRequestBody { Query = "Ragni" });

        ragni.GetKey().Should().NotBe(selchar.GetKey());
        ragni.GetKey().Should().Be(ragniAgain.GetKey());
    }
}