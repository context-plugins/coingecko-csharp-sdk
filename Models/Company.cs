using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Company
{
    /// <summary>
    /// Company name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Company ticker symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string? Symbol { get; init; }

    /// <summary>
    /// Country code
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// Total crypto holdings
    /// </summary>
    [JsonPropertyName("total_holdings")]
    public required double TotalHoldings { get; init; }

    /// <summary>
    /// Total entry value in USD
    /// </summary>
    [JsonPropertyName("total_entry_value_usd")]
    public required double TotalEntryValueUsd { get; init; }

    /// <summary>
    /// Total current value of crypto holdings in USD
    /// </summary>
    [JsonPropertyName("total_current_value_usd")]
    public required double TotalCurrentValueUsd { get; init; }

    /// <summary>
    /// Percentage of total crypto supply
    /// </summary>
    [JsonPropertyName("percentage_of_total_supply")]
    public required double PercentageOfTotalSupply { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
