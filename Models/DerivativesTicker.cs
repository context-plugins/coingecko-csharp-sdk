using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record DerivativesTicker
{
    /// <summary>
    /// Derivative market name
    /// </summary>
    [JsonPropertyName("market")]
    public required string Market { get; init; }

    /// <summary>
    /// Derivative ticker symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Derivative underlying asset
    /// </summary>
    [JsonPropertyName("index_id")]
    public required string IndexId { get; init; }

    /// <summary>
    /// Derivative ticker price
    /// </summary>
    [JsonPropertyName("price")]
    public required string Price { get; init; }

    /// <summary>
    /// Derivative ticker price percentage change in 24 hours
    /// </summary>
    [JsonPropertyName("price_percentage_change_24h")]
    public required double PricePercentageChange24H { get; init; }

    /// <summary>
    /// Derivative contract type
    /// </summary>
    [JsonPropertyName("contract_type")]
    public required string ContractType { get; init; }

    /// <summary>
    /// Derivative underlying asset price
    /// </summary>
    [JsonPropertyName("index")]
    public required double Index { get; init; }

    /// <summary>
    /// Difference of derivative price and index price
    /// </summary>
    [JsonPropertyName("basis")]
    public required double Basis { get; init; }

    /// <summary>
    /// Derivative bid-ask spread
    /// </summary>
    [JsonPropertyName("spread")]
    public required double Spread { get; init; }

    /// <summary>
    /// Derivative funding rate
    /// </summary>
    [JsonPropertyName("funding_rate")]
    public required double FundingRate { get; init; }

    /// <summary>
    /// Derivative open interest
    /// </summary>
    [JsonPropertyName("open_interest")]
    public required double OpenInterest { get; init; }

    /// <summary>
    /// Derivative trading volume in 24 hours
    /// </summary>
    [JsonPropertyName("volume_24h")]
    public required double Volume24H { get; init; }

    /// <summary>
    /// Derivative last traded time in UNIX timestamp
    /// </summary>
    [JsonPropertyName("last_traded_at")]
    public required double LastTradedAt { get; init; }

    /// <summary>
    /// Derivative expiry time in UNIX timestamp
    /// </summary>
    [JsonPropertyName("expired_at")]
    public required double? ExpiredAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
