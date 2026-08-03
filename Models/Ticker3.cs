using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Ticker3
{
    /// <summary>
    /// Ticker base currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base")]
    public string? Base { get; init; }

    /// <summary>
    /// Ticker target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public string? Target { get; init; }

    /// <summary>
    /// Exchange information
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market")]
    public Market3? Market { get; init; }

    /// <summary>
    /// Last price
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last")]
    public double? Last { get; init; }

    /// <summary>
    /// Trading volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume")]
    public double? Volume { get; init; }

    /// <summary>
    /// Converted last price
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("converted_last")]
    public ConvertedLast? ConvertedLast { get; init; }

    /// <summary>
    /// Converted trading volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("converted_volume")]
    public ConvertedVolume? ConvertedVolume { get; init; }

    /// <summary>
    /// Trust score
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trust_score")]
    public string? TrustScore { get; init; }

    /// <summary>
    /// Bid-ask spread percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bid_ask_spread_percentage")]
    public double? BidAskSpreadPercentage { get; init; }

    /// <summary>
    /// Ticker timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; init; }

    /// <summary>
    /// Last traded timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_traded_at")]
    public string? LastTradedAt { get; init; }

    /// <summary>
    /// Last fetch timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_fetch_at")]
    public string? LastFetchAt { get; init; }

    /// <summary>
    /// Whether ticker is anomalous
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_anomaly")]
    public bool? IsAnomaly { get; init; }

    /// <summary>
    /// Whether ticker is stale
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_stale")]
    public bool? IsStale { get; init; }

    /// <summary>
    /// Trade URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trade_url")]
    public string? TradeUrl { get; init; }

    /// <summary>
    /// Token info URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_info_url")]
    public string? TokenInfoUrl { get; init; }

    /// <summary>
    /// Base currency coin ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coin_id")]
    public string? CoinId { get; init; }

    /// <summary>
    /// Target currency coin ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target_coin_id")]
    public string? TargetCoinId { get; init; }

    /// <summary>
    /// Coin market cap in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coin_mcap_usd")]
    public double? CoinMcapUsd { get; init; }
}
