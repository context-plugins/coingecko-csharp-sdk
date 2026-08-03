using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Asset platform image URLs
/// </summary>
public record Image3
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

    /// <summary>
    /// Large image URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("large")]
    public string? Large { get; init; }
}
