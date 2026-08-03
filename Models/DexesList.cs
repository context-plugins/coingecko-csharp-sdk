using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record DexesList
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data32> Data { get; init; }
}
