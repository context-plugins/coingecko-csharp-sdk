using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record CoinsIdTickers
{
    /// <summary>
    /// Coin name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// List of tickers
    /// </summary>
    [JsonPropertyName("tickers")]
    public required IReadOnlyList<Ticker> Tickers { get; init; }
}
