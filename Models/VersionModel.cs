using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Token list version
/// </summary>
public record VersionModel
{
    /// <summary>
    /// Major version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("major")]
    public double? Major { get; init; }

    /// <summary>
    /// Minor version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("minor")]
    public double? Minor { get; init; }

    /// <summary>
    /// Patch version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("patch")]
    public double? Patch { get; init; }
}
