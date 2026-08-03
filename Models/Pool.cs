using System.Collections.Generic;
using System.Text.Json.Serialization;

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
}
