using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Data9
{
    /// <summary>
    /// Request ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Resource type
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    [JsonPropertyName("attributes")]
    public required Attributes4 Attributes { get; init; }
}
