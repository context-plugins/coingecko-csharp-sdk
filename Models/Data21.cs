using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data21
{
    /// <summary>
    /// Pool identifier
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Resource type
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("attributes")]
    public required Attributes12 Attributes { get; init; }

    /// <summary>
    /// Related resources
    /// </summary>
    [JsonPropertyName("relationships")]
    public required Relationships6 Relationships { get; init; }
}
