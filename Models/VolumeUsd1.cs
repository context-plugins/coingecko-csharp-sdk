using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Volume in USD
/// </summary>
public record VolumeUsd1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("h24")]
    public string? H24 { get; init; }
}
