using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Data3
{
    /// <summary>
    /// NFT collection floor price
    /// </summary>
    [JsonPropertyName("floor_price")]
    public required string FloorPrice { get; init; }

    /// <summary>
    /// NFT collection floor price in USD 24 hours percentage change
    /// </summary>
    [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
    public required string FloorPriceInUsd24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection volume in 24 hours
    /// </summary>
    [JsonPropertyName("h24_volume")]
    public required string H24Volume { get; init; }

    /// <summary>
    /// NFT collection 24 hours average sale price
    /// </summary>
    [JsonPropertyName("h24_average_sale_price")]
    public required string H24AverageSalePrice { get; init; }

    /// <summary>
    /// NFT collection sparkline image URL
    /// </summary>
    [JsonPropertyName("sparkline")]
    public required string Sparkline { get; init; }

    [JsonPropertyName("content")]
    public required Content? Content { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
