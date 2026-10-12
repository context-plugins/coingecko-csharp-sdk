using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the ContractAddressMarketChartRange operation.
/// </summary>
public sealed record ContractAddressMarketChartRangeRequest
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
    /// Starting date in UNIX timestamp.
    /// </summary>
    public int From { get; init; } = 1767024000;

    /// <summary>
    /// Ending date in UNIX timestamp.
    /// </summary>
    public int To { get; init; } = 1777564800;

    /// <summary>
    /// Decimal place for currency price value.
    /// </summary>
    public Precision? Precision { get; init; }
}
