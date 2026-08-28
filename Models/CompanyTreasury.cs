using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record CompanyTreasury
{
    /// <summary>
    /// Total crypto holdings
    /// </summary>
    [JsonPropertyName("total_holdings")]
    public required double TotalHoldings { get; init; }

    /// <summary>
    /// Total crypto holdings value in USD
    /// </summary>
    [JsonPropertyName("total_value_usd")]
    public required double TotalValueUsd { get; init; }

    /// <summary>
    /// Market cap dominance percentage
    /// </summary>
    [JsonPropertyName("market_cap_dominance")]
    public required double MarketCapDominance { get; init; }

    /// <summary>
    /// List of companies holding crypto
    /// </summary>
    [JsonPropertyName("companies")]
    public required IReadOnlyList<Company> Companies { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
