using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Sparkline price data for the last 7 days
/// </summary>
public record SparklineIn7D
{
    /// <summary>
    /// Array of price values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public IReadOnlyList<double>? Price { get; init; }
}
