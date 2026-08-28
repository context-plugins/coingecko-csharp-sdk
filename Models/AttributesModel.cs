using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record AttributesModel
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
    public required string BaseTokenPriceNativeCurrency { get; init; }

    /// <summary>
    /// Base token balance in pool
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_token_balance")]
    public string? BaseTokenBalance { get; init; }

    /// <summary>
    /// Base token liquidity in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_token_liquidity_usd")]
    public string? BaseTokenLiquidityUsd { get; init; }

    /// <summary>
    /// Quote token price in USD
    /// </summary>
    [JsonPropertyName("quote_token_price_usd")]
    public required string QuoteTokenPriceUsd { get; init; }

    /// <summary>
    /// Quote token price in native currency
    /// </summary>
    [JsonPropertyName("quote_token_price_native_currency")]
    public required string QuoteTokenPriceNativeCurrency { get; init; }

    /// <summary>
    /// Quote token balance in pool
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_token_balance")]
    public string? QuoteTokenBalance { get; init; }

    /// <summary>
    /// Quote token liquidity in USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_token_liquidity_usd")]
    public string? QuoteTokenLiquidityUsd { get; init; }

    /// <summary>
    /// Base token price in quote token
    /// </summary>
    [JsonPropertyName("base_token_price_quote_token")]
    public required string BaseTokenPriceQuoteToken { get; init; }

    /// <summary>
    /// Quote token price in base token
    /// </summary>
    [JsonPropertyName("quote_token_price_base_token")]
    public required string QuoteTokenPriceBaseToken { get; init; }

    /// <summary>
    /// Pool contract address
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    /// <summary>
    /// Pool name with fee tier
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Pool name without fee tier
    /// </summary>
    [JsonPropertyName("pool_name")]
    public required string PoolName { get; init; }

    /// <summary>
    /// Pool fee percentage
    /// </summary>
    [JsonPropertyName("pool_fee_percentage")]
    public required string PoolFeePercentage { get; init; }

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
    /// Net buy volume in USD over various timeframes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_buy_volume_usd")]
    public NetBuyVolumeUsd? NetBuyVolumeUsd { get; init; }

    /// <summary>
    /// Buy volume in USD over various timeframes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy_volume_usd")]
    public BuyVolumeUsd? BuyVolumeUsd { get; init; }

    /// <summary>
    /// Sell volume in USD over various timeframes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sell_volume_usd")]
    public SellVolumeUsd? SellVolumeUsd { get; init; }

    /// <summary>
    /// Total reserve in USD
    /// </summary>
    [JsonPropertyName("reserve_in_usd")]
    public required string ReserveInUsd { get; init; }

    /// <summary>
    /// Locked liquidity percentage
    /// </summary>
    [JsonPropertyName("locked_liquidity_percentage")]
    public required string LockedLiquidityPercentage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
