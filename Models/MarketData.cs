using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Market data at the given date
/// </summary>
public record MarketData
{
    /// <summary>
    /// Current price keyed by currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_price")]
    public IReadOnlyDictionary<string, double>? CurrentPrice { get; init; }

    /// <summary>
    /// Market capitalization keyed by currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap")]
    public IReadOnlyDictionary<string, double>? MarketCap { get; init; }

    /// <summary>
    /// Total trading volume keyed by currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_volume")]
    public IReadOnlyDictionary<string, double>? TotalVolume { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
