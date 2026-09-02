using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record MultiTokenData
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<TokenItem> Data { get; init; }

    /// <summary>
    /// Included top pool data, present when include=top_pools is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("included")]
    public IReadOnlyList<Included4>? Included { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
