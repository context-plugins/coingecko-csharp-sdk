using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Ticker4
{
    /// <summary>
    /// Derivative ticker symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Derivative base asset
    /// </summary>
    [JsonPropertyName("base")]
    public required string Base { get; init; }

    /// <summary>
    /// Derivative target asset
    /// </summary>
    [JsonPropertyName("target")]
    public required string Target { get; init; }

    /// <summary>
    /// Derivative base asset coin ID
    /// </summary>
    [JsonPropertyName("coin_id")]
    public required string CoinId { get; init; }

    /// <summary>
    /// Derivative target asset coin ID
    /// </summary>
    [JsonPropertyName("target_coin_id")]
    public required string TargetCoinId { get; init; }

    /// <summary>
    /// Derivative trade URL
    /// </summary>
    [JsonPropertyName("trade_url")]
    public required string TradeUrl { get; init; }

    /// <summary>
    /// Derivative contract type
    /// </summary>
    [JsonPropertyName("contract_type")]
    public required string ContractType { get; init; }

    /// <summary>
    /// Derivative last price
    /// </summary>
    [JsonPropertyName("last")]
    public required double Last { get; init; }

    /// <summary>
    /// Derivative price percentage change in 24 hours
    /// </summary>
    [JsonPropertyName("h24_percentage_change")]
    public required double H24PercentageChange { get; init; }

    /// <summary>
    /// Derivative underlying asset price
    /// </summary>
    [JsonPropertyName("index")]
    public required double Index { get; init; }

    /// <summary>
    /// Difference of derivative price and index price in percentage
    /// </summary>
    [JsonPropertyName("index_basis_percentage")]
    public required double IndexBasisPercentage { get; init; }

    /// <summary>
    /// Derivative bid-ask spread
    /// </summary>
    [JsonPropertyName("bid_ask_spread")]
    public required double BidAskSpread { get; init; }

    /// <summary>
    /// Derivative funding rate
    /// </summary>
    [JsonPropertyName("funding_rate")]
    public required double FundingRate { get; init; }

    /// <summary>
    /// Derivative open interest in USD
    /// </summary>
    [JsonPropertyName("open_interest_usd")]
    public required double OpenInterestUsd { get; init; }

    /// <summary>
    /// Derivative volume in 24 hours
    /// </summary>
    [JsonPropertyName("h24_volume")]
    public required double H24Volume { get; init; }

    /// <summary>
    /// Derivative converted volume
    /// </summary>
    [JsonPropertyName("converted_volume")]
    public required ConvertedVolume4 ConvertedVolume { get; init; }

    /// <summary>
    /// Derivative converted last price
    /// </summary>
    [JsonPropertyName("converted_last")]
    public required ConvertedLast4 ConvertedLast { get; init; }

    /// <summary>
    /// Derivative last traded time in UNIX timestamp
    /// </summary>
    [JsonPropertyName("last_traded")]
    public required double LastTraded { get; init; }

    /// <summary>
    /// Derivative expiry time in UNIX timestamp
    /// </summary>
    [JsonPropertyName("expired_at")]
    public required double? ExpiredAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
