using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Ticker1
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
    /// Ticker exchange
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market")]
    public Market1? Market { get; init; }

    /// <summary>
    /// Ticker last price
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last")]
    public double? Last { get; init; }

    /// <summary>
    /// Ticker volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume")]
    public double? Volume { get; init; }

    /// <summary>
    /// Ticker converted last price
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("converted_last")]
    public ConvertedLast1? ConvertedLast { get; init; }

    /// <summary>
    /// Ticker converted volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("converted_volume")]
    public ConvertedVolume1? ConvertedVolume { get; init; }

    /// <summary>
    /// Ticker trust score
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trust_score")]
    public string? TrustScore { get; init; }

    /// <summary>
    /// Ticker bid-ask spread percentage
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
    /// Ticker last traded timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_traded_at")]
    public string? LastTradedAt { get; init; }

    /// <summary>
    /// Ticker last fetch timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_fetch_at")]
    public string? LastFetchAt { get; init; }

    /// <summary>
    /// Ticker anomaly
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_anomaly")]
    public bool? IsAnomaly { get; init; }

    /// <summary>
    /// Ticker stale
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_stale")]
    public bool? IsStale { get; init; }

    /// <summary>
    /// Ticker trade URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trade_url")]
    public string? TradeUrl { get; init; }

    /// <summary>
    /// Ticker token info URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_info_url")]
    public string? TokenInfoUrl { get; init; }

    /// <summary>
    /// Ticker base currency coin ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coin_id")]
    public string? CoinId { get; init; }

    /// <summary>
    /// Ticker target currency coin ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target_coin_id")]
    public string? TargetCoinId { get; init; }

    /// <summary>
    /// Market cap in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coin_mcap_usd")]
    public double? CoinMcapUsd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
