using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Coin image URLs
/// </summary>
public record Image
{
    /// <summary>
    /// Thumbnail image URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thumb")]
    public string? Thumb { get; init; }

    /// <summary>
    /// Small image URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("small")]
    public string? Small { get; init; }
}
