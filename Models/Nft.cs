using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Nft
{
    /// <summary>
    /// NFT collection ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// NFT collection name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// NFT collection symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// NFT collection thumb image URL
    /// </summary>
    [JsonPropertyName("thumb")]
    public required string Thumb { get; init; }
}
