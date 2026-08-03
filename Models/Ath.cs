using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// NFT collection all time highs
/// </summary>
public record Ath
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("native_currency")]
    public double? NativeCurrency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd")]
    public double? Usd { get; init; }
}
