using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Relationships4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_token")]
    public BaseToken? BaseToken { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_token")]
    public QuoteToken? QuoteToken { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dex")]
    public Dex? Dex { get; init; }
}
