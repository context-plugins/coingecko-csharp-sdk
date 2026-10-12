using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Derivatives;

/// <summary>
/// The inputs of the DerivativesExchangesId operation.
/// </summary>
public sealed record DerivativesExchangesIdRequest
{
    /// <summary>
    /// Derivative exchange ID.
    /// *refers to <see href="/reference/derivatives-exchanges-list"><c>/derivatives/exchanges/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "binance_futures";

    /// <summary>
    /// Include tickers data.
    /// Default: tickers data is not included.
    /// </summary>
    public IncludeTickers? IncludeTickers { get; init; }
}
