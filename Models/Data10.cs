using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data10
{
    /// <summary>
    /// Token identifier
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Resource type
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("attributes")]
    public required Attributes5 Attributes { get; init; }

    [JsonPropertyName("relationships")]
    public required Relationships1 Relationships { get; init; }
}
