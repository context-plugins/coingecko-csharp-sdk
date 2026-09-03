using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record CategoriesList
{
    /// <summary>
    /// Category ID
    /// </summary>
    [JsonPropertyName("category_id")]
    public required string CategoryId { get; init; }

    /// <summary>
    /// Category name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
