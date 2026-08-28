using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Item
{
    /// <summary>
    /// Coin ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Coin internal ID
    /// </summary>
    [JsonPropertyName("coin_id")]
    public required int CoinId { get; init; }

    /// <summary>
    /// Coin name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Coin symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Coin market cap rank
    /// </summary>
    [JsonPropertyName("market_cap_rank")]
    public required int MarketCapRank { get; init; }

    /// <summary>
    /// Coin thumb image URL
    /// </summary>
    [JsonPropertyName("thumb")]
    public required string Thumb { get; init; }

    /// <summary>
    /// Coin small image URL
    /// </summary>
    [JsonPropertyName("small")]
    public required string Small { get; init; }

    /// <summary>
    /// Coin large image URL
    /// </summary>
    [JsonPropertyName("large")]
    public required string Large { get; init; }

    /// <summary>
    /// Coin web slug
    /// </summary>
    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    /// <summary>
    /// Coin price in BTC
    /// </summary>
    [JsonPropertyName("price_btc")]
    public required double PriceBtc { get; init; }

    /// <summary>
    /// Coin trending rank (0-based)
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; init; }

    [JsonPropertyName("data")]
    public required Data2 Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
