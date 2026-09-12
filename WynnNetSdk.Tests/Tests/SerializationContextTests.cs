using System.Text.Json;
using Tavstal.WynnNetSDK.Http;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Items.Enums;
using Tavstal.WynnNetSDK.Models.Leaderboard;
using Tavstal.WynnNetSDK.Models.Player.Responses;
using Tavstal.WynnNetSDK.Serialization;

namespace Tavstal.WynnNetSdk.Tests.Tests;

public class SerializationContextTests
{
    [Fact(DisplayName = "N/A - Every request response type is registered in the JSON context")]
    public void RegistersAllResponseTypes()
    {
        var genericBase = typeof(HttpRequestBase<>);
        var assembly = typeof(WynnHttpClient).Assembly;
        var unregistered = new List<string>();

        foreach (var type in assembly.GetTypes())
        {
            var baseType = type.BaseType;
            if (baseType is not { IsGenericType: true } || baseType.GetGenericTypeDefinition() != genericBase)
                continue;

            var responseType = baseType.GetGenericArguments()[0];
            if (WynnSdkJsonContext.Default.GetTypeInfo(responseType) == null)
                unregistered.Add($"{type.FullName} -> {responseType.FullName}");
        }

        unregistered.Should().BeEmpty();
    }

    [Fact(DisplayName = "N/A - A model survives a source-generated serialize/deserialize round trip")]
    public void RoundTripsPlayerListOnlineResponse()
    {
        var model = new PlayerListOnlineResponse
        {
            Total = 42,
            Players = new Dictionary<string, string> { ["uuid-1"] = "Nepmia" }
        };

        var json = JsonSerializer.Serialize(model, WynnSdkJsonContext.Default.PlayerListOnlineResponse);
        var back = JsonSerializer.Deserialize(json, WynnSdkJsonContext.Default.PlayerListOnlineResponse);

        back.Should().NotBeNull();
        back!.Total.Should().Be(42);
        back.Players.Should().Contain("uuid-1", "Nepmia");
    }

    [Fact(DisplayName = "N/A - Request bodies serialize enums as strings")]
    public void SerializesStringEnums()
    {
        var body = new ItemSearchRequestBody
        {
            Query = "Ragni",
            Tier = [ETier.MYTHIC, ETier.FABLED]
        };

        var json = JsonSerializer.Serialize(body, WynnSdkJsonContext.Default.ItemSearchRequestBody);

        json.Should().Contain("\"query\":\"Ragni\"");
        json.Should().Contain("\"tier\":[\"MYTHIC\",\"FABLED\"]");
    }

    [Fact(DisplayName = "N/A - Leaderboard entries deserialize into the correct sub-types")]
    public void DeserializesLeaderboardEntries()
    {
        var player = JsonSerializer.Deserialize("""{"username":"Nepmia"}""", WynnSdkJsonContext.Default.LeaderboardEntry);
        player.Should().BeOfType<LeaderboardPlayerEntry>();

        var legacy = JsonSerializer.Deserialize("""{"guildUuid":"abc"}""", WynnSdkJsonContext.Default.LeaderboardEntry);
        legacy.Should().BeOfType<LeaderboardGuildLegacyEntry>();

        var guild = JsonSerializer.Deserialize("""{"name":"Tavstal"}""", WynnSdkJsonContext.Default.LeaderboardEntry);
        guild.Should().BeOfType<LeaderboardGuildEntry>();
    }
}