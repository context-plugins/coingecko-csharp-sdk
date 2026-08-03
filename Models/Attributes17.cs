using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Attributes17
{
    /// <summary>
    /// DEX name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
