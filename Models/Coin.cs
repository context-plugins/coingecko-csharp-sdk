using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Coin
{
    /// <summary>
    /// Coin ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Coin name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Coin API symbol
    /// </summary>
    [JsonPropertyName("api_symbol")]
    public required string ApiSymbol { get; init; }

    /// <summary>
    /// Coin symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Coin market cap rank
    /// </summary>
    [JsonPropertyName("market_cap_rank")]
    public required int? MarketCapRank { get; init; }

    /// <summary>
    /// Coin thumb image URL
    /// </summary>
    [JsonPropertyName("thumb")]
    public required string Thumb { get; init; }

    /// <summary>
    /// Coin large image URL
    /// </summary>
    [JsonPropertyName("large")]
    public required string Large { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
