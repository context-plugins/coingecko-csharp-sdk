using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsId operation.
/// </summary>
public sealed record CoinsIdRequest
{
    /// <summary>
    /// Coin ID.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>
    /// </summary>
    public string Id { get; init; } = "bitcoin";

    /// <summary>
    /// Include all localized languages in the response.
    /// Default: true
    /// </summary>
    public bool? Localization { get; init; }

    /// <summary>
    /// Include tickers data.
    /// Default: true
    /// </summary>
    public bool? Tickers { get; init; }

    /// <summary>
    /// Include market data.
    /// Default: true
    /// </summary>
    public bool? MarketData { get; init; }

    /// <summary>
    /// Include community data.
    /// Default: true
    /// </summary>
    public bool? CommunityData { get; init; }

    /// <summary>
    /// Include developer data.
    /// Default: true
    /// </summary>
    public bool? DeveloperData { get; init; }

    /// <summary>
    /// Include sparkline 7-day data.
    /// Default: false
    /// </summary>
    public bool? Sparkline { get; init; }

    /// <summary>
    /// Include categories details.
    /// Default: false
    /// </summary>
    public bool? IncludeCategoriesDetails { get; init; }

    /// <summary>
    /// Set to <c>symbol</c> to display DEX pair base and target as symbols.
    /// Default: <c>contract_address</c>
    /// </summary>
    public DexPairFormat? DexPairFormat { get; init; }
}
