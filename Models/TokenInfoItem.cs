using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record TokenInfoItem
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
    public required Attributes7 Attributes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
