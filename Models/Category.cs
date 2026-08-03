using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Category
{
    /// <summary>
    /// Category ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Category name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
