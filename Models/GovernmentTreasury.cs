using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record GovernmentTreasury
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
    /// List of governments holding crypto
    /// </summary>
    [JsonPropertyName("governments")]
    public required IReadOnlyList<Government> Governments { get; init; }
}
