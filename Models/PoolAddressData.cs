using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record PoolAddressData
{
    [JsonPropertyName("data")]
    public required PoolAddressItem Data { get; init; }

    /// <summary>
    /// Included related resources, present when include parameter is specified
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("included")]
    public IReadOnlyList<Included>? Included { get; init; }
}
