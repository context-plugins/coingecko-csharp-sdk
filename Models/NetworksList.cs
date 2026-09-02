using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record NetworksList
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data33> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
