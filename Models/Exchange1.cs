using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Exchange1
{
    /// <summary>
    /// Exchange ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Exchange name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Year the exchange was established
    /// </summary>
    [JsonPropertyName("year_established")]
    public required double? YearEstablished { get; init; }

    /// <summary>
    /// Country where the exchange is based
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// Exchange description
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// Exchange website URL
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// Exchange logo URL
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; init; }

    /// <summary>
    /// Whether the exchange has trading incentive
    /// </summary>
    [JsonPropertyName("has_trading_incentive")]
    public required bool HasTradingIncentive { get; init; }

    /// <summary>
    /// Exchange trust score
    /// </summary>
    [JsonPropertyName("trust_score")]
    public required double? TrustScore { get; init; }

    /// <summary>
    /// Exchange trust score rank
    /// </summary>
    [JsonPropertyName("trust_score_rank")]
    public required double? TrustScoreRank { get; init; }

    /// <summary>
    /// Exchange 24h trading volume in BTC
    /// </summary>
    [JsonPropertyName("trade_volume_24h_btc")]
    public required double TradeVolume24HBtc { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
