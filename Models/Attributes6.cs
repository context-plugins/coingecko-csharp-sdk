using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Attributes6
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coingecko_asset_platform_id")]
    public string? CoingeckoAssetPlatformId { get; init; }
}
