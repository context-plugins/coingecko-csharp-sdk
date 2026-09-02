using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record NftData
{
    /// <summary>
    /// NFT collection ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// NFT collection web slug
    /// </summary>
    [JsonPropertyName("web_slug")]
    public required string WebSlug { get; init; }

    /// <summary>
    /// NFT collection contract address
    /// </summary>
    [JsonPropertyName("contract_address")]
    public required string ContractAddress { get; init; }

    /// <summary>
    /// NFT collection asset platform ID
    /// </summary>
    [JsonPropertyName("asset_platform_id")]
    public required string AssetPlatformId { get; init; }

    /// <summary>
    /// NFT collection name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// NFT collection symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// NFT collection image URLs
    /// </summary>
    [JsonPropertyName("image")]
    public required Image5 Image { get; init; }

    /// <summary>
    /// NFT collection banner image URL
    /// </summary>
    [JsonPropertyName("banner_image")]
    public required string BannerImage { get; init; }

    /// <summary>
    /// NFT collection description
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// NFT collection native currency
    /// </summary>
    [JsonPropertyName("native_currency")]
    public required string NativeCurrency { get; init; }

    /// <summary>
    /// NFT collection native currency symbol
    /// </summary>
    [JsonPropertyName("native_currency_symbol")]
    public required string NativeCurrencySymbol { get; init; }

    /// <summary>
    /// NFT collection market cap rank
    /// </summary>
    [JsonPropertyName("market_cap_rank")]
    public required int? MarketCapRank { get; init; }

    /// <summary>
    /// NFT collection floor price
    /// </summary>
    [JsonPropertyName("floor_price")]
    public required FloorPrice FloorPrice { get; init; }

    /// <summary>
    /// NFT collection market cap
    /// </summary>
    [JsonPropertyName("market_cap")]
    public required MarketCap MarketCap { get; init; }

    /// <summary>
    /// NFT collection volume in 24 hours
    /// </summary>
    [JsonPropertyName("volume_24h")]
    public required Volume24H Volume24H { get; init; }

    /// <summary>
    /// NFT collection floor price in USD 24 hours percentage change
    /// </summary>
    [JsonPropertyName("floor_price_in_usd_24h_percentage_change")]
    public required double FloorPriceInUsd24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection floor price 24 hours percentage change
    /// </summary>
    [JsonPropertyName("floor_price_24h_percentage_change")]
    public required FloorPrice24HPercentageChange FloorPrice24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection market cap 24 hours percentage change
    /// </summary>
    [JsonPropertyName("market_cap_24h_percentage_change")]
    public required MarketCap24HPercentageChange MarketCap24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection volume in 24 hours percentage change
    /// </summary>
    [JsonPropertyName("volume_24h_percentage_change")]
    public required Volume24HPercentageChange Volume24HPercentageChange { get; init; }

    /// <summary>
    /// Number of unique addresses owning the NFTs
    /// </summary>
    [JsonPropertyName("number_of_unique_addresses")]
    public required double NumberOfUniqueAddresses { get; init; }

    /// <summary>
    /// Number of unique addresses 24 hours percentage change
    /// </summary>
    [JsonPropertyName("number_of_unique_addresses_24h_percentage_change")]
    public required double NumberOfUniqueAddresses24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection volume in USD 24 hours percentage change
    /// </summary>
    [JsonPropertyName("volume_in_usd_24h_percentage_change")]
    public required double VolumeInUsd24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection total supply
    /// </summary>
    [JsonPropertyName("total_supply")]
    public required double TotalSupply { get; init; }

    /// <summary>
    /// NFT collection one day sales
    /// </summary>
    [JsonPropertyName("one_day_sales")]
    public required double? OneDaySales { get; init; }

    /// <summary>
    /// NFT collection one day sales 24 hours percentage change
    /// </summary>
    [JsonPropertyName("one_day_sales_24h_percentage_change")]
    public required double OneDaySales24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection one day average sale price
    /// </summary>
    [JsonPropertyName("one_day_average_sale_price")]
    public required double? OneDayAverageSalePrice { get; init; }

    /// <summary>
    /// NFT collection one day average sale price 24 hours percentage change
    /// </summary>
    [JsonPropertyName("one_day_average_sale_price_24h_percentage_change")]
    public required double OneDayAverageSalePrice24HPercentageChange { get; init; }

    /// <summary>
    /// NFT collection links
    /// </summary>
    [JsonPropertyName("links")]
    public required Links2 Links { get; init; }

    /// <summary>
    /// NFT collection floor price 7 days percentage change
    /// </summary>
    [JsonPropertyName("floor_price_7d_percentage_change")]
    public required FloorPrice7DPercentageChange FloorPrice7DPercentageChange { get; init; }

    /// <summary>
    /// NFT collection floor price 14 days percentage change
    /// </summary>
    [JsonPropertyName("floor_price_14d_percentage_change")]
    public required FloorPrice14DPercentageChange FloorPrice14DPercentageChange { get; init; }

    /// <summary>
    /// NFT collection floor price 30 days percentage change
    /// </summary>
    [JsonPropertyName("floor_price_30d_percentage_change")]
    public required FloorPrice30DPercentageChange FloorPrice30DPercentageChange { get; init; }

    /// <summary>
    /// NFT collection floor price 60 days percentage change
    /// </summary>
    [JsonPropertyName("floor_price_60d_percentage_change")]
    public required FloorPrice60DPercentageChange FloorPrice60DPercentageChange { get; init; }

    /// <summary>
    /// NFT collection floor price 1 year percentage change
    /// </summary>
    [JsonPropertyName("floor_price_1y_percentage_change")]
    public required FloorPrice1YPercentageChange FloorPrice1YPercentageChange { get; init; }

    /// <summary>
    /// NFT collection block explorer links
    /// </summary>
    [JsonPropertyName("explorers")]
    public required IReadOnlyList<Explorer> Explorers { get; init; }

    /// <summary>
    /// NFT collection user favorites count
    /// </summary>
    [JsonPropertyName("user_favorites_count")]
    public required int UserFavoritesCount { get; init; }

    /// <summary>
    /// NFT collection all time highs
    /// </summary>
    [JsonPropertyName("ath")]
    public required Ath Ath { get; init; }

    /// <summary>
    /// NFT collection all time highs change percentage
    /// </summary>
    [JsonPropertyName("ath_change_percentage")]
    public required AthChangePercentage AthChangePercentage { get; init; }

    /// <summary>
    /// NFT collection all time highs date
    /// </summary>
    [JsonPropertyName("ath_date")]
    public required AthDate AthDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
