using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record PublicTreasuryTransactionHistory
{
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<Transaction> Transactions { get; init; }
}
