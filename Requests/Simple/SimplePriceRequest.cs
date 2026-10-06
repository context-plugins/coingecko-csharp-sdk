using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Simple;

/// <summary>
/// The inputs of the SimplePrice operation.
/// </summary>
public sealed record SimplePriceRequest
{
    /// <summary>
    /// Target currency of coins, comma-separated if querying more than 1 currency.
    /// *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>
    /// </summary>
    public string VsCurrencies { get; init; } = "usd";

    /// <summary>
    /// Coins' IDs, comma-separated if querying more than 1 coin.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>
    /// </summary>
    public string Ids { get; init; } = "bitcoin";

    /// <summary>
    /// Coins' names, comma-separated if querying more than 1 coin.
    /// </summary>
    public string Names { get; init; } = "Bitcoin";

    /// <summary>
    /// Coins' symbols, comma-separated if querying more than 1 coin.
    /// </summary>
    public string Symbols { get; init; } = "btc";

    /// <summary>
    /// For <c>symbols</c> lookups, specify <c>all</c> to include all matching tokens.
    /// Default <c>top</c> returns top-ranked tokens by market cap or volume.
    /// </summary>
    public IncludeTokens? IncludeTokens { get; init; }

    /// <summary>
    /// Include market capitalization.
    /// Default: false
    /// </summary>
    public bool? IncludeMarketCap { get; init; }

    /// <summary>
    /// Include 24-hour trading volume.
    /// Default: false
    /// </summary>
    public bool? Include24HrVol { get; init; }

    /// <summary>
    /// Include 24-hour change percentage.
    /// Default: false
    /// </summary>
    public bool? Include24HrChange { get; init; }

    /// <summary>
    /// Include last updated price time as a UNIX timestamp.
    /// Default: false
    /// </summary>
    public bool? IncludeLastUpdatedAt { get; init; }

    /// <summary>
    /// Decimal places for currency price value
    /// </summary>
    public Precision? Precision { get; init; }
}
