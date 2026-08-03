using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Global
{
    [JsonPropertyName("data")]
    public required Data Data { get; init; }
}
