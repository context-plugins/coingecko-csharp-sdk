using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Attributes4
{
    /// <summary>
    /// OHLCV data as [timestamp, open, high, low, close, volume] arrays
    /// </summary>
    [JsonPropertyName("ohlcv_list")]
    public required IReadOnlyList<IReadOnlyList<double>> OhlcvList { get; init; }
}
