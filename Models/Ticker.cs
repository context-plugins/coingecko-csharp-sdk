using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Ticker
{
    /// <summary>
    /// Ticker base currency
    /// </summary>
    [JsonPropertyName("base")]
    public required string Base { get; init; }

    /// <summary>
    /// Ticker target currency
    /// </summary>
    [JsonPropertyName("target")]
    public required string Target { get; init; }

    /// <summary>
    /// Exchange information
    /// </summary>
    [JsonPropertyName("market")]
    public required Market Market { get; init; }

    /// <summary>
    /// Last price
    /// </summary>
    [JsonPropertyName("last")]
    public required double Last { get; init; }

    /// <summary>
    /// Trading volume
    /// </summary>
    [JsonPropertyName("volume")]
    public required double Volume { get; init; }

    /// <summary>
    /// Cost to move price up by 2% in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cost_to_move_up_usd")]
    public double? CostToMoveUpUsd { get; init; }

    /// <summary>
    /// Cost to move price down by 2% in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cost_to_move_down_usd")]
    public double? CostToMoveDownUsd { get; init; }

    /// <summary>
    /// Converted last price
    /// </summary>
    [JsonPropertyName("converted_last")]
    public required ConvertedLast ConvertedLast { get; init; }

    /// <summary>
    /// Converted trading volume
    /// </summary>
    [JsonPropertyName("converted_volume")]
    public required ConvertedVolume ConvertedVolume { get; init; }

    /// <summary>
    /// Trust score
    /// </summary>
    [JsonPropertyName("trust_score")]
    public required string? TrustScore { get; init; }

    /// <summary>
    /// Bid-ask spread percentage
    /// </summary>
    [JsonPropertyName("bid_ask_spread_percentage")]
    public required double BidAskSpreadPercentage { get; init; }

    /// <summary>
    /// Ticker timestamp
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required string Timestamp { get; init; }

    /// <summary>
    /// Last traded timestamp
    /// </summary>
    [JsonPropertyName("last_traded_at")]
    public required string LastTradedAt { get; init; }

    /// <summary>
    /// Last fetch timestamp
    /// </summary>
    [JsonPropertyName("last_fetch_at")]
    public required string LastFetchAt { get; init; }

    /// <summary>
    /// Whether ticker is anomalous
    /// </summary>
    [JsonPropertyName("is_anomaly")]
    public required bool IsAnomaly { get; init; }

    /// <summary>
    /// Whether ticker is stale
    /// </summary>
    [JsonPropertyName("is_stale")]
    public required bool IsStale { get; init; }

    /// <summary>
    /// Trade URL
    /// </summary>
    [JsonPropertyName("trade_url")]
    public required string TradeUrl { get; init; }

    /// <summary>
    /// Token info URL
    /// </summary>
    [JsonPropertyName("token_info_url")]
    public required string? TokenInfoUrl { get; init; }

    /// <summary>
    /// Base currency coin ID
    /// </summary>
    [JsonPropertyName("coin_id")]
    public required string CoinId { get; init; }

    /// <summary>
    /// Target currency coin ID
    /// </summary>
    [JsonPropertyName("target_coin_id")]
    public required string TargetCoinId { get; init; }

    /// <summary>
    /// Coin market cap in USD
    /// </summary>
    [JsonPropertyName("coin_mcap_usd")]
    public required double CoinMcapUsd { get; init; }
}
