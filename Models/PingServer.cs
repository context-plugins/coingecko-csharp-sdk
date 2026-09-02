using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record PingServer
{
    /// <summary>
    /// API server status message
    /// </summary>
    [JsonPropertyName("gecko_says")]
    public required string GeckoSays { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
