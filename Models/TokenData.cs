using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record TokenData
{
    [JsonPropertyName("data")]
    public required TokenItem Data { get; init; }

    /// <summary>
    /// Included top pool data, present when include=top_pools is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("included")]
    public IReadOnlyList<Included5>? Included { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
