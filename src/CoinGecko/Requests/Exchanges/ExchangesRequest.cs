namespace CoinGecko.Requests.Exchanges;

/// <summary>
/// The inputs of the ExchangesInvoke operation.
/// </summary>
public sealed record ExchangesRequest
{
    /// <summary>
    /// Total results per page.
    /// Default: 100.
    /// Valid values: 1...250
    /// </summary>
    public double? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// Default: 1
    /// </summary>
    public double? Page { get; init; }
}
