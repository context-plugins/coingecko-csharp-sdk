using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Coin1
{
    [JsonPropertyName("item")]
    public required Item Item { get; init; }
}
