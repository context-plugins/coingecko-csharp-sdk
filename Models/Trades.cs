using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Trades
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data8> Data { get; init; }
}
