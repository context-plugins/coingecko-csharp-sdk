using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record NetworksList
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data33> Data { get; init; }
}
