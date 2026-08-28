using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Public interest statistics
/// </summary>
public record PublicInterestStats
{
    /// <summary>
    /// Alexa rank
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alexa_rank")]
    public double? AlexaRank { get; init; }

    /// <summary>
    /// Bing search matches
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bing_matches")]
    public double? BingMatches { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
