using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;
using CoinGecko.Models.AnyOf;

namespace CoinGecko.Models;

public record Attributes7
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
    /// Token image URLs in different sizes
    /// </summary>
    [JsonPropertyName("image")]
    public required Image6 Image { get; init; }

    /// <summary>
    /// Token banner image URL
    /// </summary>
    [JsonPropertyName("banner_image_url")]
    public required string? BannerImageUrl { get; init; }

    /// <summary>
    /// CoinGecko coin ID
    /// </summary>
    [JsonPropertyName("coingecko_coin_id")]
    public required string? CoingeckoCoinId { get; init; }

    /// <summary>
    /// Token websites
    /// </summary>
    [JsonPropertyName("websites")]
    public required IReadOnlyList<string> Websites { get; init; }

    /// <summary>
    /// Discord URL
    /// </summary>
    [JsonPropertyName("discord_url")]
    public required string? DiscordUrl { get; init; }

    /// <summary>
    /// Farcaster URL
    /// </summary>
    [JsonPropertyName("farcaster_url")]
    public required string? FarcasterUrl { get; init; }

    /// <summary>
    /// Zora URL
    /// </summary>
    [JsonPropertyName("zora_url")]
    public required string? ZoraUrl { get; init; }

    /// <summary>
    /// Telegram handle
    /// </summary>
    [JsonPropertyName("telegram_handle")]
    public required string? TelegramHandle { get; init; }

    /// <summary>
    /// Twitter handle
    /// </summary>
    [JsonPropertyName("twitter_handle")]
    public required string? TwitterHandle { get; init; }

    /// <summary>
    /// Token description
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// GeckoTerminal trust score
    /// </summary>
    [JsonPropertyName("gt_score")]
    public required double GtScore { get; init; }

    /// <summary>
    /// GeckoTerminal trust score breakdown
    /// </summary>
    [JsonPropertyName("gt_score_details")]
    public required GtScoreDetails GtScoreDetails { get; init; }

    /// <summary>
    /// Whether the token is verified on GeckoTerminal
    /// </summary>
    [JsonPropertyName("gt_verified")]
    public required bool GtVerified { get; init; }

    /// <summary>
    /// Token categories
    /// </summary>
    [JsonPropertyName("categories")]
    public required IReadOnlyList<string> Categories { get; init; }

    /// <summary>
    /// GeckoTerminal category IDs
    /// </summary>
    [JsonPropertyName("gt_category_ids")]
    public required IReadOnlyList<string> GtCategoryIds { get; init; }

    /// <summary>
    /// Token holder information
    /// </summary>
    [JsonPropertyName("holders")]
    public required Holders Holders { get; init; }

    /// <summary>
    /// Mint authority status
    /// </summary>
    [JsonPropertyName("mint_authority")]
    public required string? MintAuthority { get; init; }

    /// <summary>
    /// Freeze authority status
    /// </summary>
    [JsonPropertyName("freeze_authority")]
    public required string? FreezeAuthority { get; init; }

    /// <summary>
    /// Whether the token is a honeypot (boolean or 'unknown')
    /// </summary>
    [JsonPropertyName("is_honeypot")]
    public required IsHoneypot IsHoneypot { get; init; }

    /// <summary>
    /// Developer wallet address
    /// </summary>
    [JsonPropertyName("developer_address")]
    public required string? DeveloperAddress { get; init; }

    /// <summary>
    /// Developer holding as a percentage of total supply
    /// </summary>
    [JsonPropertyName("developer_holding_percentage")]
    public required string? DeveloperHoldingPercentage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
