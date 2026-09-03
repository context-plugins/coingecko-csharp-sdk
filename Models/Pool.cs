using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Pool
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data21> Data { get; init; }

    /// <summary>
    /// Included related resources, present when include parameter is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("included")]
    public IReadOnlyList<Included6>? Included { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
