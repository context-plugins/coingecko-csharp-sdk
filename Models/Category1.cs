using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Category1
{
    /// <summary>
    /// Category ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Category name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Category market cap
    /// </summary>
    [JsonPropertyName("market_cap")]
    public required double MarketCap { get; init; }

    /// <summary>
    /// Category market cap change in 24 hours
    /// </summary>
    [JsonPropertyName("market_cap_change_24h")]
    public required double MarketCapChange24H { get; init; }

    /// <summary>
    /// Category description
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; init; }

    /// <summary>
    /// IDs of top 3 coins in the category
    /// </summary>
    [JsonPropertyName("top_3_coins_id")]
    public required IReadOnlyList<string> Top3CoinsId { get; init; }

    /// <summary>
    /// Image URLs of top 3 coins in the category
    /// </summary>
    [JsonPropertyName("top_3_coins")]
    public required IReadOnlyList<string> Top3Coins { get; init; }

    /// <summary>
    /// Category trading volume in 24 hours
    /// </summary>
    [JsonPropertyName("volume_24h")]
    public required double Volume24H { get; init; }

    /// <summary>
    /// Category last updated timestamp
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
