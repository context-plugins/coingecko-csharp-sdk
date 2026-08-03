using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Network
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public Data5? Data { get; init; }
}
