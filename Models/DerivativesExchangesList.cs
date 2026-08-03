using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record DerivativesExchangesList
{
    /// <summary>
    /// Derivatives exchange ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Derivatives exchange name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
