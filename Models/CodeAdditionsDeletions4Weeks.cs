using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

/// <summary>
/// Code additions and deletions in the last 4 weeks
/// </summary>
public record CodeAdditionsDeletions4Weeks
{
    /// <summary>
    /// Lines added
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additions")]
    public double? Additions { get; init; }

    /// <summary>
    /// Lines deleted
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deletions")]
    public double? Deletions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
