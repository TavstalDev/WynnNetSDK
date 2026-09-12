using System.Net;
using Tavstal.WynnNetSDK.Http.Requests.Player;
using Tavstal.WynnNetSDK.Models.Abilities;
using Tavstal.WynnNetSDK.Models.Common.Enums;
using Tavstal.WynnNetSdk.Tests.Helpers;
using Tavstal.WynnNetSdk.Tests.Models;
using Xunit.Abstractions;

namespace Tavstal.WynnNetSdk.Tests.Tests.Endpoints;

public class PlayerTests : TestBase
{
    public PlayerTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper,
    [
        "Resources/Player/GetProfile.json",
        "Resources/Player/ListOnline.json",
        "Resources/Player/ListCharacters.json",
        "Resources/Player/WhoAmI.json",
        "Resources/Player/GetCharacter.json",
        "Resources/Player/GetAbilityMap.json"
    ])
    {
    }

    [Fact(DisplayName = "Sample 1 - 200 - Get Player Profile")]
    public async Task Player_GetProfile()
    {
        var resource = _resources[0];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PlayerGetProfileRequest("Nepmia");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var profile = await request.GetResponseBodyAsync(response);
        profile.Should().NotBeNull();

        _testOutputHelper.WriteLine("Player: " + profile!.Username);
        _testOutputHelper.WriteLine("Player UUID: " + profile.Uuid);
        _testOutputHelper.WriteLine("Player Rank: " + profile.Rank);
        _testOutputHelper.WriteLine("Player Level: " + profile.GlobalData.TotalLevel);
        profile.Guild.Should().NotBeNull();
        _testOutputHelper.WriteLine("Guild: " + profile.Guild!.Name);
    }

    [Fact(DisplayName = "Sample 2 - 200 - List Online Players")]
    public async Task Player_ListOnline()
    {
        var resource = _resources[1];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PlayerListOnlineRequest(EIdentifier.NAME, (string?)null);

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var online = await request.GetResponseBodyAsync(response);
        online.Should().NotBeNull();

        _testOutputHelper.WriteLine("Total Online: " + online!.Total);
        _testOutputHelper.WriteLine("Players:");
        foreach (var player in online.Players)
            _testOutputHelper.WriteLine($"  {player.Key} -> {player.Value}");
    }

    [Fact(DisplayName = "Sample 3 - 200 - List Player Characters")]
    public async Task Player_ListCharacters()
    {
        var resource = _resources[2];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PlayerListCharactersRequest("Nepmia");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var characters = await request.GetResponseBodyAsync(response);
        characters.Should().NotBeNull();

        _testOutputHelper.WriteLine("Characters:");
        foreach (var character in characters!)
        {
            _testOutputHelper.WriteLine($"  {character.Key} -> Level {character.Value.Level} {character.Value.Type}");
            character.Value.Type.Should().Be("ASSASSIN");
        }
    }

    [Fact(DisplayName = "Sample 4 - 200 - Who Am I")]
    public async Task Player_WhoAmI()
    {
        var resource = _resources[3];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PlayerWhoAmIRequest();

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var players = await request.GetResponseBodyAsync(response);
        players.Should().NotBeNull();

        _testOutputHelper.WriteLine("Players:");
        foreach (var player in players!)
        {
            _testOutputHelper.WriteLine($"  {player.Value.Username} -> {player.Value.Rank}");
            player.Value.Username.Should().Be("Nepmia");
        }
    }

    [Fact(DisplayName = "Sample 5 - 200 - Get Player Character")]
    public async Task Player_GetCharacter()
    {
        var resource = _resources[4];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PlayerGetCharacterRequest("Nepmia", "5b6ab8a0-8f7c-4f50-bd2c-bfabe22d74bc");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var character = await request.GetResponseBodyAsync(response);
        character.Should().NotBeNull();

        _testOutputHelper.WriteLine("Character Type: " + character!.Type);
        _testOutputHelper.WriteLine("Character Level: " + character.Level);
        _testOutputHelper.WriteLine("Character Total Level: " + character.TotalLevel);
        character.Type.Should().Be("ASSASSIN");
    }

    [Fact(DisplayName = "Sample 6 - 200 - Get Player Ability Map")]
    public async Task Player_GetAbilityMap()
    {
        var resource = _resources[5];
        var client = FakeHttpHelpers.CreateClient(resource.Responder);

        var request = new PlayerGetAbilityMapRequest("Nepmia", "5b6ab8a0-8f7c-4f50-bd2c-bfabe22d74bc");

        var response = await client.SendAsync(request);
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var abilityMap = await request.GetResponseBodyAsync(response);
        abilityMap.Should().NotBeNull();

        _testOutputHelper.WriteLine("Ability Map:");
        foreach (var entry in abilityMap!)
        {
            foreach (var innerEntry in entry.Value)
            {
                _testOutputHelper.WriteLine(
                    $"  {entry.Key} -> {innerEntry.Type} @ ({innerEntry.Coordinates.X}, {innerEntry.Coordinates.Y})");
            }
        }
    }
}
