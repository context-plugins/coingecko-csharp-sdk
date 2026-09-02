using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Attributes18
{
    /// <summary>
    /// Network name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Corresponding CoinGecko asset platform ID
    /// </summary>
    [JsonPropertyName("coingecko_asset_platform_id")]
    public required string CoingeckoAssetPlatformId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
