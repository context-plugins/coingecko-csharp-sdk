using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Market data
/// </summary>
public record MarketData1
{
    /// <summary>
    /// Current price in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_price")]
    public IReadOnlyDictionary<string, double>? CurrentPrice { get; init; }

    /// <summary>
    /// Total value locked
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_value_locked")]
    public double? TotalValueLocked { get; init; }

    /// <summary>
    /// Market cap to TVL ratio
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcap_to_tvl_ratio")]
    public double? McapToTvlRatio { get; init; }

    /// <summary>
    /// FDV to TVL ratio
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fdv_to_tvl_ratio")]
    public double? FdvToTvlRatio { get; init; }

    /// <summary>
    /// Return on investment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roi")]
    public Roi? Roi { get; init; }

    /// <summary>
    /// All-time high in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ath")]
    public IReadOnlyDictionary<string, double>? Ath { get; init; }

    /// <summary>
    /// All-time high change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ath_change_percentage")]
    public IReadOnlyDictionary<string, double>? AthChangePercentage { get; init; }

    /// <summary>
    /// All-time high date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ath_date")]
    public IReadOnlyDictionary<string, string>? AthDate { get; init; }

    /// <summary>
    /// All-time low in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("atl")]
    public IReadOnlyDictionary<string, double>? Atl { get; init; }

    /// <summary>
    /// All-time low change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("atl_change_percentage")]
    public IReadOnlyDictionary<string, double>? AtlChangePercentage { get; init; }

    /// <summary>
    /// All-time low date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("atl_date")]
    public IReadOnlyDictionary<string, string>? AtlDate { get; init; }

    /// <summary>
    /// Market cap in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap")]
    public IReadOnlyDictionary<string, double>? MarketCap { get; init; }

    /// <summary>
    /// Fully diluted valuation in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fully_diluted_valuation")]
    public IReadOnlyDictionary<string, double>? FullyDilutedValuation { get; init; }

    /// <summary>
    /// Market cap to FDV ratio
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_fdv_ratio")]
    public double? MarketCapFdvRatio { get; init; }

    /// <summary>
    /// Market cap rank
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_rank")]
    public int? MarketCapRank { get; init; }

    /// <summary>
    /// Outstanding token value in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outstanding_token_value_usd")]
    public double? OutstandingTokenValueUsd { get; init; }

    /// <summary>
    /// Market cap rank including rehypothecated tokens
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_rank_with_rehypothecated")]
    public int? MarketCapRankWithRehypothecated { get; init; }

    /// <summary>
    /// Total trading volume in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_volume")]
    public IReadOnlyDictionary<string, double>? TotalVolume { get; init; }

    /// <summary>
    /// 24h price high in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("high_24h")]
    public IReadOnlyDictionary<string, double>? High24H { get; init; }

    /// <summary>
    /// 24h price low in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("low_24h")]
    public IReadOnlyDictionary<string, double>? Low24H { get; init; }

    /// <summary>
    /// 24h price change in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_24h")]
    public double? PriceChange24H { get; init; }

    /// <summary>
    /// 24h price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_24h")]
    public double? PriceChangePercentage24H { get; init; }

    /// <summary>
    /// 7d price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_7d")]
    public double? PriceChangePercentage7D { get; init; }

    /// <summary>
    /// 14d price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_14d")]
    public double? PriceChangePercentage14D { get; init; }

    /// <summary>
    /// 30d price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_30d")]
    public double? PriceChangePercentage30D { get; init; }

    /// <summary>
    /// 60d price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_60d")]
    public double? PriceChangePercentage60D { get; init; }

    /// <summary>
    /// 200d price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_200d")]
    public double? PriceChangePercentage200D { get; init; }

    /// <summary>
    /// 1y price change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_1y")]
    public double? PriceChangePercentage1Y { get; init; }

    /// <summary>
    /// 24h market cap change in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_change_24h")]
    public double? MarketCapChange24H { get; init; }

    /// <summary>
    /// 24h market cap change percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_change_percentage_24h")]
    public double? MarketCapChangePercentage24H { get; init; }

    /// <summary>
    /// 24h price change in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_24h_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChange24HInCurrency { get; init; }

    /// <summary>
    /// 1h price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_1h_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage1HInCurrency { get; init; }

    /// <summary>
    /// 24h price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_24h_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage24HInCurrency { get; init; }

    /// <summary>
    /// 7d price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_7d_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage7DInCurrency { get; init; }

    /// <summary>
    /// 14d price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_14d_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage14DInCurrency { get; init; }

    /// <summary>
    /// 30d price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_30d_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage30DInCurrency { get; init; }

    /// <summary>
    /// 60d price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_60d_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage60DInCurrency { get; init; }

    /// <summary>
    /// 200d price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_200d_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage200DInCurrency { get; init; }

    /// <summary>
    /// 1y price change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price_change_percentage_1y_in_currency")]
    public IReadOnlyDictionary<string, double>? PriceChangePercentage1YInCurrency { get; init; }

    /// <summary>
    /// 24h market cap change in target currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_change_24h_in_currency")]
    public IReadOnlyDictionary<string, double>? MarketCapChange24HInCurrency { get; init; }

    /// <summary>
    /// 24h market cap change percentage per currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_change_percentage_24h_in_currency")]
    public IReadOnlyDictionary<string, double>? MarketCapChangePercentage24HInCurrency { get; init; }

    /// <summary>
    /// Total supply
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_supply")]
    public double? TotalSupply { get; init; }

    /// <summary>
    /// Max supply
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_supply")]
    public double? MaxSupply { get; init; }

    /// <summary>
    /// Max supply infinite
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_supply_infinite")]
    public bool? MaxSupplyInfinite { get; init; }

    /// <summary>
    /// Circulating supply
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("circulating_supply")]
    public double? CirculatingSupply { get; init; }

    /// <summary>
    /// Tokens outstanding in the market
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outstanding_supply")]
    public double? OutstandingSupply { get; init; }

    /// <summary>
    /// Market data last updated timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_updated")]
    public string? LastUpdated { get; init; }

    /// <summary>
    /// Sparkline 7-day price data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sparkline_7d")]
    public IReadOnlyList<double>? Sparkline7D { get; init; }
}
