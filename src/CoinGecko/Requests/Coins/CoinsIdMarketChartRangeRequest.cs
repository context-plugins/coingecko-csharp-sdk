using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsIdMarketChartRange operation.
/// </summary>
public sealed record CoinsIdMarketChartRangeRequest
{
    /// <summary>
    /// Coin ID.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "bitcoin";

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
