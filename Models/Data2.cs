using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data2
{
    /// <summary>
    /// Coin price in USD
    /// </summary>
    [JsonPropertyName("price")]
    public required double Price { get; init; }

    /// <summary>
    /// Coin price in BTC
    /// </summary>
    [JsonPropertyName("price_btc")]
    public required string PriceBtc { get; init; }

    /// <summary>
    /// Coin price change percentage in 24 hours by currency
    /// </summary>
    [JsonPropertyName("price_change_percentage_24h")]
    public required IReadOnlyDictionary<string, double> PriceChangePercentage24H { get; init; }

    /// <summary>
    /// Coin market cap in USD
    /// </summary>
    [JsonPropertyName("market_cap")]
    public required string MarketCap { get; init; }

    /// <summary>
    /// Coin market cap in BTC
    /// </summary>
    [JsonPropertyName("market_cap_btc")]
    public required string MarketCapBtc { get; init; }

    /// <summary>
    /// Coin total volume in USD
    /// </summary>
    [JsonPropertyName("total_volume")]
    public required string TotalVolume { get; init; }

    /// <summary>
    /// Coin total volume in BTC
    /// </summary>
    [JsonPropertyName("total_volume_btc")]
    public required string TotalVolumeBtc { get; init; }

    /// <summary>
    /// Coin sparkline image URL
    /// </summary>
    [JsonPropertyName("sparkline")]
    public required string Sparkline { get; init; }

    [JsonPropertyName("content")]
    public required Content? Content { get; init; }
}
