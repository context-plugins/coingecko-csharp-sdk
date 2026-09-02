using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record ExchangesId
{
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
    /// Facebook URL
    /// </summary>
    [JsonPropertyName("facebook_url")]
    public required string FacebookUrl { get; init; }

    /// <summary>
    /// Reddit URL
    /// </summary>
    [JsonPropertyName("reddit_url")]
    public required string RedditUrl { get; init; }

    /// <summary>
    /// Telegram URL
    /// </summary>
    [JsonPropertyName("telegram_url")]
    public required string TelegramUrl { get; init; }

    /// <summary>
    /// Slack URL
    /// </summary>
    [JsonPropertyName("slack_url")]
    public required string SlackUrl { get; init; }

    /// <summary>
    /// Other URL 1
    /// </summary>
    [JsonPropertyName("other_url_1")]
    public required string OtherUrl1 { get; init; }

    /// <summary>
    /// Other URL 2
    /// </summary>
    [JsonPropertyName("other_url_2")]
    public required string OtherUrl2 { get; init; }

    /// <summary>
    /// Twitter handle
    /// </summary>
    [JsonPropertyName("twitter_handle")]
    public required string TwitterHandle { get; init; }

    /// <summary>
    /// Whether the exchange has trading incentive
    /// </summary>
    [JsonPropertyName("has_trading_incentive")]
    public required bool HasTradingIncentive { get; init; }

    /// <summary>
    /// Whether the exchange is centralized
    /// </summary>
    [JsonPropertyName("centralized")]
    public required bool Centralized { get; init; }

    /// <summary>
    /// Public notice
    /// </summary>
    [JsonPropertyName("public_notice")]
    public required string PublicNotice { get; init; }

    /// <summary>
    /// Alert notice
    /// </summary>
    [JsonPropertyName("alert_notice")]
    public required string AlertNotice { get; init; }

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
    /// Number of coins listed
    /// </summary>
    [JsonPropertyName("coins")]
    public required double Coins { get; init; }

    /// <summary>
    /// Number of trading pairs
    /// </summary>
    [JsonPropertyName("pairs")]
    public required double Pairs { get; init; }

    /// <summary>
    /// Exchange 24h trading volume in BTC
    /// </summary>
    [JsonPropertyName("trade_volume_24h_btc")]
    public required double TradeVolume24HBtc { get; init; }

    /// <summary>
    /// Exchange tickers
    /// </summary>
    [JsonPropertyName("tickers")]
    public required IReadOnlyList<Ticker3> Tickers { get; init; }

    /// <summary>
    /// Status updates
    /// </summary>
    [JsonPropertyName("status_updates")]
    public required IReadOnlyList<StatusUpdate2> StatusUpdates { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
