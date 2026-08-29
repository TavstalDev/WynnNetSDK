using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Http.Requests.Items.Bodies;
using Tavstal.WynnNetSDK.Models.Common;

namespace Tavstal.WynnNetSDK.Serialization;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, UseStringEnumConverter = true)]
[JsonSerializable(typeof(ErrorResponse))]
[JsonSerializable(typeof(ItemSearchRequestBody))]
public partial class WynnNetSDKJsonContext : JsonSerializerContext;