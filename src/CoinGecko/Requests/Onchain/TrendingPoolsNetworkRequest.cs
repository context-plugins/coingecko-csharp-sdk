using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the TrendingPoolsNetwork operation.
/// </summary>
public sealed record TrendingPoolsNetworkRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Attributes to include, comma-separated if more than one.
    /// Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>
    /// </summary>
    public string? Include { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Duration to sort trending list by.
    /// Default: <c>24h</c>
    /// </summary>
    public Duration? Duration { get; init; }

    /// <summary>
    /// Include GeckoTerminal community data (sentiment votes, suspicious reports).
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeGtCommunityData { get; init; }
}
