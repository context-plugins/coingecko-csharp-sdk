using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Relationships3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("top_pools")]
    public TopPools? TopPools { get; init; }
}
