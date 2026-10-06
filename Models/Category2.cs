using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Category2
{
    /// <summary>
    /// Category ID
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; init; }

    /// <summary>
    /// Category name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Top 3 coins image URLs in the category
    /// </summary>
    [JsonPropertyName("top_3_coins_images")]
    public required IReadOnlyList<string> Top3CoinsImages { get; init; }

    /// <summary>
    /// Category market cap 1 hour change
    /// </summary>
    [JsonPropertyName("market_cap_1h_change")]
    public required double MarketCap1HChange { get; init; }

    /// <summary>
    /// Category web slug
    /// </summary>
    [JsonPropertyName("slug")]
    public required string Slug { get; init; }

    /// <summary>
    /// Number of coins in the category
    /// </summary>
    [JsonPropertyName("coins_count")]
    public required string CoinsCount { get; init; }

    [JsonPropertyName("data")]
    public required Data4 Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
