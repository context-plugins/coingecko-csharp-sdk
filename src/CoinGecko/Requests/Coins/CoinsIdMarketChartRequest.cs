using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsIdMarketChart operation.
/// </summary>
public sealed record CoinsIdMarketChartRequest
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
