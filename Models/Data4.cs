using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Data4
{
    /// <summary>
    /// Category market cap
    /// </summary>
    [JsonPropertyName("market_cap")]
    public required double MarketCap { get; init; }

    /// <summary>
    /// Category market cap in BTC
    /// </summary>
    [JsonPropertyName("market_cap_btc")]
    public required double MarketCapBtc { get; init; }

    /// <summary>
    /// Category total volume
    /// </summary>
    [JsonPropertyName("total_volume")]
    public required double TotalVolume { get; init; }

    /// <summary>
    /// Category total volume in BTC
    /// </summary>
    [JsonPropertyName("total_volume_btc")]
    public required double TotalVolumeBtc { get; init; }

    /// <summary>
    /// Category market cap change percentage in 24 hours by currency
    /// </summary>
    [JsonPropertyName("market_cap_change_percentage_24h")]
    public required IReadOnlyDictionary<string, double> MarketCapChangePercentage24H { get; init; }

    /// <summary>
    /// Category sparkline image URL
    /// </summary>
    [JsonPropertyName("sparkline")]
    public required string Sparkline { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
