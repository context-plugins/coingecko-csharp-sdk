using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

/// <summary>
/// Ticker converted volume
/// </summary>
public record ConvertedVolume1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("btc")]
    public double? Btc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eth")]
    public double? Eth { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd")]
    public double? Usd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
