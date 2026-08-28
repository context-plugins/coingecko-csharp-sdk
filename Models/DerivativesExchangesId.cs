using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record DerivativesExchangesId
{
    /// <summary>
    /// Derivatives exchange name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Derivatives exchange open interest in BTC
    /// </summary>
    [JsonPropertyName("open_interest_btc")]
    public required double? OpenInterestBtc { get; init; }

    /// <summary>
    /// Derivatives exchange trade volume in BTC in 24 hours
    /// </summary>
    [JsonPropertyName("trade_volume_24h_btc")]
    public required string TradeVolume24HBtc { get; init; }

    /// <summary>
    /// Number of perpetual pairs in the derivatives exchange
    /// </summary>
    [JsonPropertyName("number_of_perpetual_pairs")]
    public required int NumberOfPerpetualPairs { get; init; }

    /// <summary>
    /// Number of futures pairs in the derivatives exchange
    /// </summary>
    [JsonPropertyName("number_of_futures_pairs")]
    public required int NumberOfFuturesPairs { get; init; }

    /// <summary>
    /// Derivatives exchange image URL
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; init; }

    /// <summary>
    /// Derivatives exchange established year
    /// </summary>
    [JsonPropertyName("year_established")]
    public required int? YearEstablished { get; init; }

    /// <summary>
    /// Derivatives exchange incorporated country
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// Derivatives exchange description
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Derivatives exchange website URL
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// Derivative tickers data, available when include_tickers is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tickers")]
    public IReadOnlyList<Ticker4>? Tickers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
