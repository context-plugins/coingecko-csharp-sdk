using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Exchange
{
    /// <summary>
    /// Exchange ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Exchange name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Exchange market type
    /// </summary>
    [JsonPropertyName("market_type")]
    public required string MarketType { get; init; }

    /// <summary>
    /// Exchange thumb image URL
    /// </summary>
    [JsonPropertyName("thumb")]
    public required string Thumb { get; init; }

    /// <summary>
    /// Exchange large image URL
    /// </summary>
    [JsonPropertyName("large")]
    public required string Large { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
