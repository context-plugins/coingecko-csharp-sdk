using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record ExchangeRates
{
    /// <summary>
    /// Exchange rates keyed by currency code
    /// </summary>
    [JsonPropertyName("rates")]
    public required IReadOnlyDictionary<string, Rates> Rates { get; init; }
}
