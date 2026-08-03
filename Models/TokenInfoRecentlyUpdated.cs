using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record TokenInfoRecentlyUpdated
{
    [JsonPropertyName("data")]
    public required IReadOnlyList<Data10> Data { get; init; }

    /// <summary>
    /// Included network data, present when include=network is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("included")]
    public IReadOnlyList<Included2>? Included { get; init; }
}
