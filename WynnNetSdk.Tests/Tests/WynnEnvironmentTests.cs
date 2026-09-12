using Tavstal.WynnNetSDK.Http;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class WynnEnvironmentTests
{
    [Fact(DisplayName = "N/A - Single-argument constructor uses the default base URL")]
    public void UsesDefaultBaseUrl()
    {
        var environment = new WynnEnvironment("token123");

        environment.BaseUrl.Should().Be("https://api.wynncraft.com");
        environment.Token.Should().Be("token123");
    }

    [Fact(DisplayName = "N/A - Two-argument constructor keeps the custom base URL")]
    public void KeepsCustomBaseUrl()
    {
        var environment = new WynnEnvironment("https://example.com", "token123");

        environment.BaseUrl.Should().Be("https://example.com");
        environment.Token.Should().Be("token123");
    }

    [Theory(DisplayName = "N/A - Constructor rejects an empty or blank token")]
    [InlineData("")]
    [InlineData("   ")]
    public void RejectsEmptyToken(string token)
    {
        Action act = () => new WynnEnvironment("https://api.wynncraft.com", token);

        act.Should().Throw<ArgumentException>().WithParameterName("token");
    }

    [Fact(DisplayName = "N/A - Constructor rejects a null token")]
    public void RejectsNullToken()
    {
        Action act = () => new WynnEnvironment("https://api.wynncraft.com", null!);

        act.Should().Throw<ArgumentException>().WithParameterName("token");
    }

    [Theory(DisplayName = "N/A - Constructor rejects an empty or blank base URL")]
    [InlineData("")]
    [InlineData("   ")]
    public void RejectsEmptyBaseUrl(string baseUrl)
    {
        Action act = () => new WynnEnvironment(baseUrl, "token123");

        act.Should().Throw<ArgumentException>().WithParameterName("baseUrl");
    }
}