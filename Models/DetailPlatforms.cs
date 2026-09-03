using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record DetailPlatforms
{
    /// <summary>
    /// Token decimal place
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("decimal_place")]
    public int? DecimalPlace { get; init; }

    /// <summary>
    /// Token contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contract_address")]
    public string? ContractAddress { get; init; }

    /// <summary>
    /// GeckoTerminal URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("geckoterminal_url")]
    public string? GeckoterminalUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
