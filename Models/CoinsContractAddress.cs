using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record CoinsContractAddress
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
    /// Coin web slug
    /// </summary>
    [JsonPropertyName("web_slug")]
    public required string WebSlug { get; init; }

    /// <summary>
    /// Coin asset platform ID
    /// </summary>
    [JsonPropertyName("asset_platform_id")]
    public required string? AssetPlatformId { get; init; }

    /// <summary>
    /// Coin asset platform and contract address
    /// </summary>
    [JsonPropertyName("platforms")]
    public required IReadOnlyDictionary<string, string> Platforms { get; init; }

    /// <summary>
    /// Detailed coin asset platform and contract address
    /// </summary>
    [JsonPropertyName("detail_platforms")]
    public required IReadOnlyDictionary<string, DetailPlatforms> DetailPlatforms { get; init; }

    /// <summary>
    /// Blockchain block time in minutes
    /// </summary>
    [JsonPropertyName("block_time_in_minutes")]
    public required double BlockTimeInMinutes { get; init; }

    /// <summary>
    /// Blockchain hashing algorithm
    /// </summary>
    [JsonPropertyName("hashing_algorithm")]
    public required string? HashingAlgorithm { get; init; }

    /// <summary>
    /// Coin categories
    /// </summary>
    [JsonPropertyName("categories")]
    public required IReadOnlyList<string> Categories { get; init; }

    /// <summary>
    /// Preview listing coin
    /// </summary>
    [JsonPropertyName("preview_listing")]
    public required bool PreviewListing { get; init; }

    /// <summary>
    /// Public notice
    /// </summary>
    [JsonPropertyName("public_notice")]
    public required string? PublicNotice { get; init; }

    /// <summary>
    /// Additional notices
    /// </summary>
    [JsonPropertyName("additional_notices")]
    public required IReadOnlyList<string> AdditionalNotices { get; init; }

    /// <summary>
    /// Whether detailed supply breakdown data is available via /coins/supply_breakdown
    /// </summary>
    [JsonPropertyName("has_supply_breakdown")]
    public required bool HasSupplyBreakdown { get; init; }

    /// <summary>
    /// Coin name localization
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localization")]
    public IReadOnlyDictionary<string, string>? Localization { get; init; }

    /// <summary>
    /// Coin description
    /// </summary>
    [JsonPropertyName("description")]
    public required IReadOnlyDictionary<string, string> Description { get; init; }

    /// <summary>
    /// Links
    /// </summary>
    [JsonPropertyName("links")]
    public required Links Links { get; init; }

    /// <summary>
    /// Coin image URL
    /// </summary>
    [JsonPropertyName("image")]
    public required Image1 Image { get; init; }

    /// <summary>
    /// Country of origin
    /// </summary>
    [JsonPropertyName("country_origin")]
    public required string CountryOrigin { get; init; }

    /// <summary>
    /// Genesis date
    /// </summary>
    [JsonPropertyName("genesis_date")]
    public required string? GenesisDate { get; init; }

    /// <summary>
    /// Coin contract address
    /// </summary>
    [JsonPropertyName("contract_address")]
    public required string ContractAddress { get; init; }

    /// <summary>
    /// Sentiment votes up percentage
    /// </summary>
    [JsonPropertyName("sentiment_votes_up_percentage")]
    public required double? SentimentVotesUpPercentage { get; init; }

    /// <summary>
    /// Sentiment votes down percentage
    /// </summary>
    [JsonPropertyName("sentiment_votes_down_percentage")]
    public required double? SentimentVotesDownPercentage { get; init; }

    /// <summary>
    /// Number of users watching this coin in portfolio
    /// </summary>
    [JsonPropertyName("watchlist_portfolio_users")]
    public required double WatchlistPortfolioUsers { get; init; }

    /// <summary>
    /// Market cap rank
    /// </summary>
    [JsonPropertyName("market_cap_rank")]
    public required int? MarketCapRank { get; init; }

    /// <summary>
    /// Market cap rank including rehypothecated tokens
    /// </summary>
    [JsonPropertyName("market_cap_rank_with_rehypothecated")]
    public required int? MarketCapRankWithRehypothecated { get; init; }

    /// <summary>
    /// Market data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_data")]
    public MarketData1? MarketData { get; init; }

    /// <summary>
    /// Community data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("community_data")]
    public CommunityData1? CommunityData { get; init; }

    /// <summary>
    /// Developer data
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("developer_data")]
    public DeveloperData1? DeveloperData { get; init; }

    /// <summary>
    /// Status updates
    /// </summary>
    [JsonPropertyName("status_updates")]
    public required IReadOnlyList<StatusUpdate> StatusUpdates { get; init; }

    /// <summary>
    /// Last updated timestamp
    /// </summary>
    [JsonPropertyName("last_updated")]
    public required string LastUpdated { get; init; }

    /// <summary>
    /// Tickers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tickers")]
    public IReadOnlyList<Ticker1>? Tickers { get; init; }
}
