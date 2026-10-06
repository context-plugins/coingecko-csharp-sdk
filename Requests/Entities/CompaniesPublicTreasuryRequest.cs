using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Entities;

/// <summary>
/// The inputs of the CompaniesPublicTreasury operation.
/// </summary>
public sealed record CompaniesPublicTreasuryRequest
{
    /// <summary>
    /// Public company or government entity.
    /// </summary>
    public Entity Entity { get; init; } = Entity.Companies;

    /// <summary>
    /// Coin ID.
    /// e.g. <c>bitcoin</c>, <c>ethereum</c>, <c>solana</c>, <c>binancecoin</c>
    /// </summary>
    public string CoinId { get; init; } = "bitcoin";

    /// <summary>
    /// Total results per page.
    /// Default value: 250
    /// Valid values: 1...250
    /// </summary>
    public int? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Sort order for results.
    /// Default: <c>total_holdings_usd_desc</c>
    /// </summary>
    public Order5? Order { get; init; }
}
