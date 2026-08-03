using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Attributes5
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
    public required double? GtScore { get; init; }

    /// <summary>
    /// Metadata last updated timestamp
    /// </summary>
    [JsonPropertyName("metadata_updated_at")]
    public required string MetadataUpdatedAt { get; init; }
}
