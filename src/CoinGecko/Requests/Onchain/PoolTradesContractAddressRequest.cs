namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the PoolTradesContractAddress operation.
/// </summary>
public sealed record PoolTradesContractAddressRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Pool contract address.
    /// </summary>
    public string PoolAddress { get; init; } = "0x06da0fd433c1a5d7a4faa01111c044910a184553";

    /// <summary>
    /// Filter trades by trade volume in USD greater than this value.
    /// Default value: 0
    /// </summary>
    public double? TradeVolumeInUsdGreaterThan { get; init; }

    /// <summary>
    /// Return trades for token, use this to invert the chart.
    /// Available values: <c>base</c>, <c>quote</c>, or token address.
    /// Default: <c>base</c>
    /// </summary>
    public string? Token { get; init; }
}
