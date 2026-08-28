using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Attributes9
{
    /// <summary>
    /// Token contract address
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; init; }

    /// <summary>
    /// Token name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Token symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Token decimals
    /// </summary>
    [JsonPropertyName("decimals")]
    public required int Decimals { get; init; }

    /// <summary>
    /// Token image URL
    /// </summary>
    [JsonPropertyName("image_url")]
    public required string? ImageUrl { get; init; }

    /// <summary>
    /// CoinGecko coin ID
    /// </summary>
    [JsonPropertyName("coingecko_coin_id")]
    public required string? CoingeckoCoinId { get; init; }

    /// <summary>
    /// Token total supply
    /// </summary>
    [JsonPropertyName("total_supply")]
    public required string TotalSupply { get; init; }

    /// <summary>
    /// Normalized token total supply
    /// </summary>
    [JsonPropertyName("normalized_total_supply")]
    public required string NormalizedTotalSupply { get; init; }

    /// <summary>
    /// Token price in USD
    /// </summary>
    [JsonPropertyName("price_usd")]
    public required string? PriceUsd { get; init; }

    /// <summary>
    /// Fully diluted valuation in USD
    /// </summary>
    [JsonPropertyName("fdv_usd")]
    public required string? FdvUsd { get; init; }

    /// <summary>
    /// Total reserve in USD across all pools
    /// </summary>
    [JsonPropertyName("total_reserve_in_usd")]
    public required string TotalReserveInUsd { get; init; }

    /// <summary>
    /// Volume in USD
    /// </summary>
    [JsonPropertyName("volume_usd")]
    public required VolumeUsd1 VolumeUsd { get; init; }

    /// <summary>
    /// Market cap in USD
    /// </summary>
    [JsonPropertyName("market_cap_usd")]
    public required string? MarketCapUsd { get; init; }

    /// <summary>
    /// Last trade timestamp in UNIX
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_trade_timestamp")]
    public string? LastTradeTimestamp { get; init; }

    /// <summary>
    /// Launchpad details for pump-style tokens
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("launchpad_details")]
    public LaunchpadDetails? LaunchpadDetails { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
