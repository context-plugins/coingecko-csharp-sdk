using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsIdOhlc operation.
/// </summary>
public sealed record CoinsIdOhlcRequest
{
    /// <summary>
    /// Coin ID.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "bitcoin";

    /// <summary>
    /// Target currency of price data.
    /// *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.
    /// </summary>
    public string VsCurrency { get; init; } = "usd";

    /// <summary>
    /// Data up to number of days ago.
    /// </summary>
    public Days Days { get; init; } = Days._1;

    /// <summary>
    /// Decimal place for currency price value.
    /// </summary>
    public Precision? Precision { get; init; }
}
