using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record TrendingSearch
{
    [JsonPropertyName("coins")]
    public required IReadOnlyList<Coin1> Coins { get; init; }

    [JsonPropertyName("nfts")]
    public required IReadOnlyList<Nft1> Nfts { get; init; }

    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category2> Categories { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
