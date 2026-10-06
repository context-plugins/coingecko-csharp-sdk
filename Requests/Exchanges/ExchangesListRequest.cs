using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Exchanges;

/// <summary>
/// The inputs of the ExchangesList operation.
/// </summary>
public sealed record ExchangesListRequest
{
    /// <summary>
    /// Filter by status of exchanges.
    /// Default: <c>active</c>
    /// </summary>
    public Status? Status { get; init; }
}
