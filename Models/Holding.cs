using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Holding
{
    /// <summary>
    /// Coin ID
    /// </summary>
    [JsonPropertyName("coin_id")]
    public required string CoinId { get; init; }

    /// <summary>
    /// Amount of cryptocurrency held
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// Percentage of total crypto supply
    /// </summary>
    [JsonPropertyName("percentage_of_total_supply")]
    public required double PercentageOfTotalSupply { get; init; }

    /// <summary>
    /// Amount of cryptocurrency per share
    /// </summary>
    [JsonPropertyName("amount_per_share")]
    public required double AmountPerShare { get; init; }

    /// <summary>
    /// Percentage of entity's total treasury value
    /// </summary>
    [JsonPropertyName("entity_value_usd_percentage")]
    public required double EntityValueUsdPercentage { get; init; }

    /// <summary>
    /// Current value of holdings in USD
    /// </summary>
    [JsonPropertyName("current_value_usd")]
    public required double CurrentValueUsd { get; init; }

    /// <summary>
    /// Total entry cost in USD
    /// </summary>
    [JsonPropertyName("total_entry_value_usd")]
    public required double TotalEntryValueUsd { get; init; }

    /// <summary>
    /// Average entry cost per unit in USD
    /// </summary>
    [JsonPropertyName("average_entry_value_usd")]
    public required double AverageEntryValueUsd { get; init; }

    /// <summary>
    /// Unrealized profit and loss for this holding
    /// </summary>
    [JsonPropertyName("unrealized_pnl")]
    public required double UnrealizedPnl { get; init; }

    /// <summary>
    /// Holding amount changes over different timeframes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holding_amount_change")]
    public HoldingAmountChange? HoldingAmountChange { get; init; }

    /// <summary>
    /// Holding change percentages over different timeframes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("holding_change_percentage")]
    public HoldingChangePercentage? HoldingChangePercentage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
