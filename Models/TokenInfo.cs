using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record TokenInfo
{
    [JsonPropertyName("data")]
    public required TokenInfoItem Data { get; init; }
}
