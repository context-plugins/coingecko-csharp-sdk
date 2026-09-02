using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

/// <summary>
/// Derivative converted volume
/// </summary>
public record ConvertedVolume4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("btc")]
    public string? Btc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eth")]
    public string? Eth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd")]
    public string? Usd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
