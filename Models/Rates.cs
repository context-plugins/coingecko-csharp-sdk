using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Rates
{
    /// <summary>
    /// Currency name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Currency unit symbol
    /// </summary>
    [JsonPropertyName("unit")]
    public required string Unit { get; init; }

    /// <summary>
    /// Exchange rate value relative to BTC
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }

    /// <summary>
    /// Currency type: crypto, fiat, or commodity
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
