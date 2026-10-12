namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the OnchainSimplePrice operation.
/// </summary>
public sealed record OnchainSimplePriceRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Token contract address, comma-separated if more than one token contract address.
    /// </summary>
    public string Addresses { get; init; } = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2";

    /// <summary>
    /// Include market capitalization.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeMarketCap { get; init; }

    /// <summary>
    /// Return FDV if market cap is not available.
    /// Default: <c>false</c>
    /// </summary>
    public bool? McapFdvFallback { get; init; }

    /// <summary>
    /// Include 24hr volume.
    /// Default: <c>false</c>
    /// </summary>
    public bool? Include24HrVol { get; init; }

    /// <summary>
    /// Include 24hr price change.
    /// Default: <c>false</c>
    /// </summary>
    public bool? Include24HrPriceChange { get; init; }

    /// <summary>
    /// Include total reserve in USD.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeTotalReserveInUsd { get; init; }

    /// <summary>
    /// Include token price data from inactive pools using the most recent swap.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeInactiveSource { get; init; }
}
