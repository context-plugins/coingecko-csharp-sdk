using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record PoolSearch
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data26> Data { get; init; }

    /// <summary>
    /// Included related resources, present when include parameter is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("included")]
    public IReadOnlyList<Included6>? Included { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
