using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the PoolOhlcvContractAddress operation.
/// </summary>
public sealed record PoolOhlcvContractAddressRequest
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
    /// Timeframe of the OHLCV chart.
    /// </summary>
    public Timeframe Timeframe { get; init; } = Timeframe.Day;

    /// <summary>
    /// Time period to aggregate each OHLCV.
    /// Available values (day): <c>1</c>
    /// Available values (hour): <c>1</c>, <c>4</c>, <c>12</c>
    /// Available values (minute): <c>1</c>, <c>5</c>, <c>15</c>
    /// Default value: 1
    /// </summary>
    public string? Aggregate { get; init; }

    /// <summary>
    /// Return OHLCV data before this timestamp (integer seconds since epoch).
    /// </summary>
    public int? BeforeTimestamp { get; init; }

    /// <summary>
    /// Number of OHLCV results to return, maximum 1000.
    /// Default value: 100
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Return OHLCV in USD or quote token.
    /// Default: <c>usd</c>
    /// </summary>
    public Currency? Currency { get; init; }

    /// <summary>
    /// Return OHLCV for token, use this to invert the chart.
    /// Available values: <c>base</c>, <c>quote</c>, or token address.
    /// Default: <c>base</c>
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Include empty intervals with no trade data.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeEmptyIntervals { get; init; }
}
