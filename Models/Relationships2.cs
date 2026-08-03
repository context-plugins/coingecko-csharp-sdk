using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Relationships2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pool")]
    public Pool2? Pool { get; init; }
}
