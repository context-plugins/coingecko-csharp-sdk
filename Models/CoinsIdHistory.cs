using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record CoinsIdHistory
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
    /// Localized coin names keyed by locale code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localization")]
    public IReadOnlyDictionary<string, string>? Localization { get; init; }

    /// <summary>
    /// Coin image URLs
    /// </summary>
    [JsonPropertyName("image")]
    public required Image Image { get; init; }

    /// <summary>
    /// Market data at the given date
    /// </summary>
    [JsonPropertyName("market_data")]
    public required MarketData MarketData { get; init; }

    /// <summary>
    /// Community engagement data
    /// </summary>
    [JsonPropertyName("community_data")]
    public required CommunityData CommunityData { get; init; }

    /// <summary>
    /// Developer activity data
    /// </summary>
    [JsonPropertyName("developer_data")]
    public required DeveloperData DeveloperData { get; init; }

    /// <summary>
    /// Public interest statistics
    /// </summary>
    [JsonPropertyName("public_interest_stats")]
    public required PublicInterestStats PublicInterestStats { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
