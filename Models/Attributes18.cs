using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

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
}
