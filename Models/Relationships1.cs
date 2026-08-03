using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Relationships1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("network")]
    public Network? Network { get; init; }
}
