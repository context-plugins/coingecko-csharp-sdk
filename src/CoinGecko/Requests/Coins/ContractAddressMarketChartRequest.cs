using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the ContractAddressMarketChart operation.
/// </summary>
public sealed record ContractAddressMarketChartRequest
{
    /// <summary>
    /// Asset platform ID.
    /// *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.
    /// </summary>
    public string Id { get; init; } = "ethereum";

    /// <summary>
    /// The contract address of token.
    /// </summary>
    public string ContractAddress { get; init; } = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48";

    /// <summary>
    /// Target currency of market data.
    /// *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.
    /// </summary>
    public string VsCurrency { get; init; } = "usd";

    /// <summary>
    /// Data up to number of days ago.
    /// You may use any integer or <c>max</c> for number of days.
    /// </summary>
    public string Days { get; init; } = "1";

    /// <summary>
    /// Data interval, leave empty for auto granularity.
    /// </summary>
    public Interval? Interval { get; init; }

    /// <summary>
    /// Decimal place for currency price value.
    /// </summary>
    public Precision? Precision { get; init; }
}
