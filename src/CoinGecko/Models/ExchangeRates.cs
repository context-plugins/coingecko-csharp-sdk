using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record ExchangeRates
{
    /// <summary>
    /// Exchange rates keyed by currency code
    /// </summary>
    [JsonPropertyName("rates")]
    public required IReadOnlyDictionary<string, Rates> Rates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
