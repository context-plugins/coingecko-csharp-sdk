using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record PublicTreasuryTransactionHistory
{
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<Transaction> Transactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
