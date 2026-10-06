using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.PublicTreasuryApi;

/// <summary>
/// The inputs of the PublicTreasuryTransactionHistory operation.
/// </summary>
public sealed record PublicTreasuryTransactionHistoryRequest
{
    /// <summary>
    /// Public company or government entity ID.
    /// *refers to <see href="/reference/entities-list"><c>/entities/list</c></see>.
    /// </summary>
    public string EntityId { get; init; } = "strategy";

    /// <summary>
    /// Total results per page.
    /// Default value: 100
    /// Valid values: 1...250
    /// </summary>
    public int? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Sort order of transactions.
    /// Default: <c>date_desc</c>
    /// </summary>
    public Order6? Order { get; init; }

    /// <summary>
    /// Filter transactions by coin IDs, comma-separated if querying more than 1 coin.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.
    /// </summary>
    public string? CoinIds { get; init; }
}
