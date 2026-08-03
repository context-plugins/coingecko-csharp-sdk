using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record QuoteToken
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public Data5? Data { get; init; }
}
