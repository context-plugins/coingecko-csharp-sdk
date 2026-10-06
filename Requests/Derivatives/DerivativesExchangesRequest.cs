using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Derivatives;

/// <summary>
/// The inputs of the DerivativesExchanges operation.
/// </summary>
public sealed record DerivativesExchangesRequest
{
    /// <summary>
    /// Sort order of responses.
    /// Default: <c>open_interest_btc_desc</c>
    /// </summary>
    public Order4? Order { get; init; }

    /// <summary>
    /// Total results per page.
    /// </summary>
    public int? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }
}
