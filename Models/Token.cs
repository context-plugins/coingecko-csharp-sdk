using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Token
{
    /// <summary>
    /// Chainlist's chain ID
    /// </summary>
    [JsonPropertyName("chainId")]
    public required double ChainId { get; init; }

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
    public required double Decimals { get; init; }

    /// <summary>
    /// Token image URL
    /// </summary>
    [JsonPropertyName("logoURI")]
    public required string LogoUri { get; init; }
}
