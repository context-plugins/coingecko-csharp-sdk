using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Relationships3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_pools")]
    public TopPools? TopPools { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
