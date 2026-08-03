using System.Text.Json.Serialization;

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
}
