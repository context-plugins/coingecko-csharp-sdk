using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record CoinsList
{
    /// <summary>
    /// Coin ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Coin symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Coin name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Asset platform and contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platforms")]
    public IReadOnlyDictionary<string, string>? Platforms { get; init; }
}
