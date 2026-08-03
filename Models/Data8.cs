using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data8
{
    /// <summary>
    /// Trade identifier
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Resource type
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("attributes")]
    public required Attributes3 Attributes { get; init; }
}
