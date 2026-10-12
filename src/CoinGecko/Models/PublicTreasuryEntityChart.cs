using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record PublicTreasuryEntityChart
{
    /// <summary>
    /// Historical holdings data as [timestamp, amount] pairs
    /// </summary>
    [JsonPropertyName("holdings")]
    public required IReadOnlyList<IReadOnlyList<double>> Holdings { get; init; }

    /// <summary>
    /// Historical holdings value in USD as [timestamp, value_usd] pairs
    /// </summary>
    [JsonPropertyName("holding_value_in_usd")]
    public required IReadOnlyList<IReadOnlyList<double>> HoldingValueInUsd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
