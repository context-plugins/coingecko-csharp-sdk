using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Code additions and deletions in 4 weeks
/// </summary>
public record CodeAdditionsDeletions4Weeks1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additions")]
    public double? Additions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deletions")]
    public double? Deletions { get; init; }
}
