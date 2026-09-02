using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Ohlcv
{
    [JsonPropertyName("data")]
    public required Data9 Data { get; init; }

    [JsonPropertyName("meta")]
    public required Meta Meta { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
