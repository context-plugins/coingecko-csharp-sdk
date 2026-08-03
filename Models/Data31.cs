using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data31
{
    /// <summary>
    /// Request ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Response type
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("attributes")]
    public required Attributes16 Attributes { get; init; }
}
