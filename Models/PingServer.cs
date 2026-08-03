using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record PingServer
{
    /// <summary>
    /// API server status message
    /// </summary>
    [JsonPropertyName("gecko_says")]
    public required string GeckoSays { get; init; }
}
