using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record OnchainSimplePrice
{
    [JsonPropertyName("data")]
    public required Data31 Data { get; init; }
}
