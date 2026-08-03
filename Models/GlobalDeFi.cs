using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record GlobalDeFi
{
    [JsonPropertyName("data")]
    public required Data1 Data { get; init; }
}
