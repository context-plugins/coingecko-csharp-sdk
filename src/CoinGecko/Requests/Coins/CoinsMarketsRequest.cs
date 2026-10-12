using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsMarkets operation.
/// </summary>
public sealed record CoinsMarketsRequest
{
    /// <summary>
    /// Target currency of coins and market data.
    /// *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>
    /// </summary>
    public string VsCurrency { get; init; } = "usd";

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
    /// Filter based on coins' category.
    /// *refers to <see href="/reference/coins-categories-list"><c>/coins/categories/list</c></see>
    /// </summary>
    public string? Category { get; init; }

    /// <summary>
    /// Sort result by field.
    /// Default: market_cap_desc
    /// </summary>
    public Order? Order { get; init; }

    /// <summary>
    /// Total results per page.
    /// Default: 100
    /// Valid values: 1...250
    /// </summary>
    public int? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// Default: 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Include sparkline 7-day data.
    /// Default: false
    /// </summary>
    public bool? Sparkline { get; init; }

    /// <summary>
    /// Include price change percentage timeframe, comma-separated if querying more than 1 timeframe.
    /// Valid values: <c>1h</c>, <c>24h</c>, <c>7d</c>, <c>14d</c>, <c>30d</c>, <c>200d</c>, <c>1y</c>
    /// </summary>
    public string? PriceChangePercentage { get; init; }

    /// <summary>
    /// Language background.
    /// Default: en
    /// </summary>
    public Locale? Locale { get; init; }

    /// <summary>
    /// Decimal places for currency price value
    /// </summary>
    public Precision? Precision { get; init; }

    /// <summary>
    /// Include rehypothecated tokens in results. When true, returns <c>market_cap_rank_with_rehypothecated</c> field.
    /// Default: false
    /// </summary>
    public bool? IncludeRehypothecated { get; init; }
}
