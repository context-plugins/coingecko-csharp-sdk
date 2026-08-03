using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Ohlcv
{
    [JsonPropertyName("data")]
    public required Data9 Data { get; init; }

    [JsonPropertyName("meta")]
    public required Meta Meta { get; init; }
}
