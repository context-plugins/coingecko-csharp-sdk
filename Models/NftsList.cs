using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record NftsList
{
    /// <summary>
    /// NFT collection ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// NFT collection contract address
    /// </summary>
    [JsonPropertyName("contract_address")]
    public required string ContractAddress { get; init; }

    /// <summary>
    /// NFT collection name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// NFT collection asset platform ID
    /// </summary>
    [JsonPropertyName("asset_platform_id")]
    public required string AssetPlatformId { get; init; }

    /// <summary>
    /// NFT collection symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
}
