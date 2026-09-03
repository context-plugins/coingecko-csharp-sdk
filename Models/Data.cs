using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Data
{
    /// <summary>
    /// Number of active cryptocurrencies
    /// </summary>
    [JsonPropertyName("active_cryptocurrencies")]
    public required int ActiveCryptocurrencies { get; init; }

    /// <summary>
    /// Number of upcoming ICOs
    /// </summary>
    [JsonPropertyName("upcoming_icos")]
    public required int UpcomingIcos { get; init; }

    /// <summary>
    /// Number of ongoing ICOs
    /// </summary>
    [JsonPropertyName("ongoing_icos")]
    public required int OngoingIcos { get; init; }

    /// <summary>
    /// Number of ended ICOs
    /// </summary>
    [JsonPropertyName("ended_icos")]
    public required int EndedIcos { get; init; }

    /// <summary>
    /// Number of exchanges
    /// </summary>
    [JsonPropertyName("markets")]
    public required int Markets { get; init; }

    /// <summary>
    /// Total cryptocurrency market cap by currency
    /// </summary>
    [JsonPropertyName("total_market_cap")]
    public required IReadOnlyDictionary<string, double> TotalMarketCap { get; init; }

    /// <summary>
    /// Total cryptocurrency volume by currency
    /// </summary>
    [JsonPropertyName("total_volume")]
    public required IReadOnlyDictionary<string, double> TotalVolume { get; init; }

    /// <summary>
    /// Market cap percentage by coin
    /// </summary>
    [JsonPropertyName("market_cap_percentage")]
    public required IReadOnlyDictionary<string, double> MarketCapPercentage { get; init; }

    /// <summary>
    /// Market cap change percentage in 24 hours in USD
    /// </summary>
    [JsonPropertyName("market_cap_change_percentage_24h_usd")]
    public required double MarketCapChangePercentage24HUsd { get; init; }

    /// <summary>
    /// Volume change percentage in 24 hours in USD
    /// </summary>
    [JsonPropertyName("volume_change_percentage_24h_usd")]
    public required double VolumeChangePercentage24HUsd { get; init; }

    /// <summary>
    /// Last updated time in UNIX timestamp
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required int UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
