using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data33
{
    /// <summary>
    /// Network identifier
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Resource type
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("attributes")]
    public required Attributes18 Attributes { get; init; }
}
