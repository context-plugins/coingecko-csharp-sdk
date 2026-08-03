using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// NFT collection floor price 7 days percentage change
/// </summary>
public record FloorPrice7DPercentageChange
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd")]
    public double? Usd { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("native_currency")]
    public double? NativeCurrency { get; init; }
}
