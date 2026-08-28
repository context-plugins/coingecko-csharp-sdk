using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

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
