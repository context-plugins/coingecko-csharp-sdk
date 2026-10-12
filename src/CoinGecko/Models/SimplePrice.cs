using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record SimplePrice
{
    /// <summary>
    /// Price in the target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd")]
    public double? Usd { get; init; }

    /// <summary>
    /// Market capitalization in the target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd_market_cap")]
    public double? UsdMarketCap { get; init; }

    /// <summary>
    /// 24-hour trading volume in the target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd_24h_vol")]
    public double? Usd24HVol { get; init; }

    /// <summary>
    /// 24-hour price change percentage in the target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usd_24h_change")]
    public double? Usd24HChange { get; init; }

    /// <summary>
    /// Last updated timestamp in UNIX seconds
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_updated_at")]
    public double? LastUpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
