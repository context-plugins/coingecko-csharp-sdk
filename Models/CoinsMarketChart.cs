using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record CoinsMarketChart
{
    /// <summary>
    /// Price data points as [timestamp, price] pairs
    /// </summary>
    [JsonPropertyName("prices")]
    public required IReadOnlyList<IReadOnlyList<double>> Prices { get; init; }

    /// <summary>
    /// Market cap data points as [timestamp, market_cap] pairs
    /// </summary>
    [JsonPropertyName("market_caps")]
    public required IReadOnlyList<IReadOnlyList<double>> MarketCaps { get; init; }

    /// <summary>
    /// Total volume data points as [timestamp, volume] pairs
    /// </summary>
    [JsonPropertyName("total_volumes")]
    public required IReadOnlyList<IReadOnlyList<double>> TotalVolumes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
