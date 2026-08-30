using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Http.Requests.Recipes.Bodies;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Serialization;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, UseStringEnumConverter = true)]
[JsonSerializable(typeof(ErrorResponse))]
[JsonSerializable(typeof(ItemSearchRequestBody))]
[JsonSerializable(typeof(RecipesSearchRequestBody))]
public partial class WynnNetSDKJsonContext : JsonSerializerContext;