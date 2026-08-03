using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// NFT collection floor price 1 year percentage change
/// </summary>
public record FloorPrice1YPercentageChange
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd")]
    public double? Usd { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("native_currency")]
    public double? NativeCurrency { get; init; }
}
