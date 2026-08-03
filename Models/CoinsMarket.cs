using System;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record CoinsMarket
{
    /// <summary>
    /// Coin ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Coin symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Coin name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Coin image URL
    /// </summary>
    [JsonPropertyName("image")]
    public required string Image { get; init; }

    /// <summary>
    /// Current price in target currency
    /// </summary>
    [JsonPropertyName("current_price")]
    public required double? CurrentPrice { get; init; }

    /// <summary>
    /// Market cap in target currency
    /// </summary>
    [JsonPropertyName("market_cap")]
    public required double? MarketCap { get; init; }

    /// <summary>
    /// Market cap rank
    /// </summary>
    [JsonPropertyName("market_cap_rank")]
    public required int? MarketCapRank { get; init; }

    /// <summary>
    /// Fully diluted valuation in target currency
    /// </summary>
    [JsonPropertyName("fully_diluted_valuation")]
    public required double? FullyDilutedValuation { get; init; }

    /// <summary>
    /// Total trading volume in target currency
    /// </summary>
    [JsonPropertyName("total_volume")]
    public required double? TotalVolume { get; init; }

    /// <summary>
    /// 24-hour price high in target currency
    /// </summary>
    [JsonPropertyName("high_24h")]
    public required double? High24H { get; init; }

    /// <summary>
    /// 24-hour price low in target currency
    /// </summary>
    [JsonPropertyName("low_24h")]
    public required double? Low24H { get; init; }

    /// <summary>
    /// 24-hour price change in target currency
    /// </summary>
    [JsonPropertyName("price_change_24h")]
    public required double? PriceChange24H { get; init; }

    /// <summary>
    /// 24-hour price change percentage
    /// </summary>
    [JsonPropertyName("price_change_percentage_24h")]
    public required double? PriceChangePercentage24H { get; init; }

    /// <summary>
    /// 24-hour market cap change in target currency
    /// </summary>
    [JsonPropertyName("market_cap_change_24h")]
    public required double? MarketCapChange24H { get; init; }

    /// <summary>
    /// 24-hour market cap change percentage
    /// </summary>
    [JsonPropertyName("market_cap_change_percentage_24h")]
    public required double? MarketCapChangePercentage24H { get; init; }

    /// <summary>
    /// Circulating supply
    /// </summary>
    [JsonPropertyName("circulating_supply")]
    public required double? CirculatingSupply { get; init; }

    /// <summary>
    /// Total supply
    /// </summary>
    [JsonPropertyName("total_supply")]
    public required double? TotalSupply { get; init; }

    /// <summary>
    /// Max supply
    /// </summary>
    [JsonPropertyName("max_supply")]
    public required double? MaxSupply { get; init; }

    /// <summary>
    /// All-time high price in target currency
    /// </summary>
    [JsonPropertyName("ath")]
    public required double? Ath { get; init; }

    /// <summary>
    /// All-time high change percentage
    /// </summary>
    [JsonPropertyName("ath_change_percentage")]
    public required double? AthChangePercentage { get; init; }

    /// <summary>
    /// All-time high date
    /// </summary>
    [JsonPropertyName("ath_date")]
    public required DateTimeOffset? AthDate { get; init; }

    /// <summary>
    /// All-time low price in target currency
    /// </summary>
    [JsonPropertyName("atl")]
    public required double? Atl { get; init; }

    /// <summary>
    /// All-time low change percentage
    /// </summary>
    [JsonPropertyName("atl_change_percentage")]
    public required double? AtlChangePercentage { get; init; }

    /// <summary>
    /// All-time low date
    /// </summary>
    [JsonPropertyName("atl_date")]
    public required DateTimeOffset? AtlDate { get; init; }

    /// <summary>
    /// Return on investment data
    /// </summary>
    [JsonPropertyName("roi")]
    public required Roi2? Roi { get; init; }

    /// <summary>
    /// Last updated timestamp
    /// </summary>
    [JsonPropertyName("last_updated")]
    public required DateTimeOffset LastUpdated { get; init; }

    /// <summary>
    /// Market cap rank including rehypothecated tokens
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_rank_with_rehypothecated")]
    public int? MarketCapRankWithRehypothecated { get; init; }

    /// <summary>
    /// Sparkline price data for the last 7 days
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sparkline_in_7d")]
    public SparklineIn7D? SparklineIn7D { get; init; }

    /// <summary>
    /// 1-hour price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_1h_in_currency")]
    public double? PriceChangePercentage1HInCurrency { get; init; }

    /// <summary>
    /// 24-hour price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_24h_in_currency")]
    public double? PriceChangePercentage24HInCurrency { get; init; }

    /// <summary>
    /// 7-day price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_7d_in_currency")]
    public double? PriceChangePercentage7DInCurrency { get; init; }

    /// <summary>
    /// 14-day price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_14d_in_currency")]
    public double? PriceChangePercentage14DInCurrency { get; init; }

    /// <summary>
    /// 30-day price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_30d_in_currency")]
    public double? PriceChangePercentage30DInCurrency { get; init; }

    /// <summary>
    /// 200-day price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_200d_in_currency")]
    public double? PriceChangePercentage200DInCurrency { get; init; }

    /// <summary>
    /// 1-year price change percentage in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_1y_in_currency")]
    public double? PriceChangePercentage1YInCurrency { get; init; }
}
