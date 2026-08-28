using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;
using CoinGeckoDemoApi.Models.Enums;

namespace CoinGeckoDemoApi.Models;

public record Transaction
{
    /// <summary>
    /// Transaction date in UNIX timestamp
    /// </summary>
    [JsonPropertyName("date")]
    public required double Date { get; init; }

    /// <summary>
    /// Source document URL
    /// </summary>
    [JsonPropertyName("source_url")]
    public required string SourceUrl { get; init; }

    /// <summary>
    /// Coin ID
    /// </summary>
    [JsonPropertyName("coin_id")]
    public required string CoinId { get; init; }

    /// <summary>
    /// Transaction type
    /// </summary>
    [JsonPropertyName("type")]
    public required TypeEnum Type { get; init; }

    /// <summary>
    /// Net change in holdings after the transaction
    /// </summary>
    [JsonPropertyName("holding_net_change")]
    public required double HoldingNetChange { get; init; }

    /// <summary>
    /// Transaction value in USD
    /// </summary>
    [JsonPropertyName("transaction_value_usd")]
    public required double TransactionValueUsd { get; init; }

    /// <summary>
    /// Total holding balance after the transaction
    /// </summary>
    [JsonPropertyName("holding_balance")]
    public required double HoldingBalance { get; init; }

    /// <summary>
    /// Average entry value in USD after the transaction
    /// </summary>
    [JsonPropertyName("average_entry_value_usd")]
    public required double AverageEntryValueUsd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
