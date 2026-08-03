using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record ExchangesList
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
}
