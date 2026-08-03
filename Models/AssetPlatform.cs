using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record AssetPlatform
{
    /// <summary>
    /// Asset platform ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Chainlist's chain ID
    /// </summary>
    [JsonPropertyName("chain_identifier")]
    public required double? ChainIdentifier { get; init; }

    /// <summary>
    /// Chain name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Chain shortname
    /// </summary>
    [JsonPropertyName("shortname")]
    public required string Shortname { get; init; }

    /// <summary>
    /// Chain native coin ID
    /// </summary>
    [JsonPropertyName("native_coin_id")]
    public required string? NativeCoinId { get; init; }

    /// <summary>
    /// Asset platform image URLs
    /// </summary>
    [JsonPropertyName("image")]
    public required Image3 Image { get; init; }
}
