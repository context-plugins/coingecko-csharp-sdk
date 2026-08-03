using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Attributes12
{
    /// <summary>
    /// Base token price in USD
    /// </summary>
    [JsonPropertyName("base_token_price_usd")]
    public required string BaseTokenPriceUsd { get; init; }

    /// <summary>
    /// Base token price in native currency
    /// </summary>
    [JsonPropertyName("base_token_price_native_currency")]
    public required string? BaseTokenPriceNativeCurrency { get; init; }

    /// <summary>
    /// Quote token price in USD
    /// </summary>
    [JsonPropertyName("quote_token_price_usd")]
    public required string QuoteTokenPriceUsd { get; init; }

    /// <summary>
    /// Quote token price in native currency
    /// </summary>
    [JsonPropertyName("quote_token_price_native_currency")]
    public required string? QuoteTokenPriceNativeCurrency { get; init; }

    /// <summary>
    /// Base token price in quote token
    /// </summary>
    [JsonPropertyName("base_token_price_quote_token")]
    public required string? BaseTokenPriceQuoteToken { get; init; }

    /// <summary>
    /// Quote token price in base token
    /// </summary>
    [JsonPropertyName("quote_token_price_base_token")]
    public required string? QuoteTokenPriceBaseToken { get; init; }

    /// <summary>
    /// Pool contract address
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    /// <summary>
    /// Pool name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Pool creation timestamp
    /// </summary>
    [JsonPropertyName("pool_created_at")]
    public required string PoolCreatedAt { get; init; }

    /// <summary>
    /// Fully diluted valuation in USD
    /// </summary>
    [JsonPropertyName("fdv_usd")]
    public required string? FdvUsd { get; init; }

    /// <summary>
    /// Market cap in USD
    /// </summary>
    [JsonPropertyName("market_cap_usd")]
    public required string? MarketCapUsd { get; init; }

    /// <summary>
    /// Price change percentage over various timeframes
    /// </summary>
    [JsonPropertyName("price_change_percentage")]
    public required PriceChangePercentage PriceChangePercentage { get; init; }

    /// <summary>
    /// Transaction counts over various timeframes
    /// </summary>
    [JsonPropertyName("transactions")]
    public required Transactions Transactions { get; init; }

    /// <summary>
    /// Volume in USD over various timeframes
    /// </summary>
    [JsonPropertyName("volume_usd")]
    public required VolumeUsd VolumeUsd { get; init; }

    /// <summary>
    /// Total reserve in USD
    /// </summary>
    [JsonPropertyName("reserve_in_usd")]
    public required string? ReserveInUsd { get; init; }

    /// <summary>
    /// Price of the queried token in USD, present when querying pools by token address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token_price_usd")]
    public string? TokenPriceUsd { get; init; }

    /// <summary>
    /// GeckoTerminal community positive sentiment vote percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_vote_positive_percentage")]
    public double? SentimentVotePositivePercentage { get; init; }

    /// <summary>
    /// GeckoTerminal community negative sentiment vote percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_vote_negative_percentage")]
    public double? SentimentVoteNegativePercentage { get; init; }

    /// <summary>
    /// GeckoTerminal community suspicious reports count
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("community_sus_report")]
    public int? CommunitySusReport { get; init; }
}
