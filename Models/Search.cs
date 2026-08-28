using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Search
{
    [JsonPropertyName("coins")]
    public required IReadOnlyList<Coin> Coins { get; init; }

    [JsonPropertyName("exchanges")]
    public required IReadOnlyList<Exchange> Exchanges { get; init; }

    [JsonPropertyName("icos")]
    public required IReadOnlyList<object> Icos { get; init; }

    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category> Categories { get; init; }

    [JsonPropertyName("nfts")]
    public required IReadOnlyList<Nft> Nfts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
