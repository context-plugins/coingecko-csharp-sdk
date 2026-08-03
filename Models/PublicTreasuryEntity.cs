using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record PublicTreasuryEntity
{
    /// <summary>
    /// Entity name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Entity ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Entity type: company or government
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// Stock market ticker symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string? Symbol { get; init; }

    /// <summary>
    /// Country code
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// Official website URL
    /// </summary>
    [JsonPropertyName("website_url")]
    public required string WebsiteUrl { get; init; }

    /// <summary>
    /// Official Twitter handle
    /// </summary>
    [JsonPropertyName("twitter_screen_name")]
    public required string TwitterScreenName { get; init; }

    /// <summary>
    /// Total current value of all holdings in USD
    /// </summary>
    [JsonPropertyName("total_treasury_value_usd")]
    public required double TotalTreasuryValueUsd { get; init; }

    /// <summary>
    /// Unrealized profit and loss (current value minus total entry value)
    /// </summary>
    [JsonPropertyName("unrealized_pnl")]
    public required double UnrealizedPnl { get; init; }

    /// <summary>
    /// Market to net asset value ratio
    /// </summary>
    [JsonPropertyName("m_nav")]
    public required double MNav { get; init; }

    /// <summary>
    /// Total asset value per share in USD
    /// </summary>
    [JsonPropertyName("total_asset_value_per_share_usd")]
    public required double TotalAssetValuePerShareUsd { get; init; }

    /// <summary>
    /// List of cryptocurrency assets held by the entity
    /// </summary>
    [JsonPropertyName("holdings")]
    public required IReadOnlyList<Holding> Holdings { get; init; }
}
