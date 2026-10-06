using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsIdTickers operation.
/// </summary>
public sealed record CoinsIdTickersRequest
{
    /// <summary>
    /// Coin ID.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>
    /// </summary>
    public string Id { get; init; } = "bitcoin";

    /// <summary>
    /// Exchange ID.
    /// *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see>
    /// </summary>
    public string? ExchangeIds { get; init; }

    /// <summary>
    /// Include exchange logo.
    /// Default: false
    /// </summary>
    public bool? IncludeExchangeLogo { get; init; }

    /// <summary>
    /// Page through results
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Sort the order of responses.
    /// Default: trust_score_desc
    /// </summary>
    public Order1? Order { get; init; }

    /// <summary>
    /// Include 2% orderbook depth, i.e. <c>cost_to_move_up_usd</c> and <c>cost_to_move_down_usd</c>.
    /// Default: false
    /// </summary>
    public bool? Depth { get; init; }

    /// <summary>
    /// Set to <c>symbol</c> to display DEX pair base and target as symbols.
    /// Default: <c>contract_address</c>
    /// </summary>
    public DexPairFormat? DexPairFormat { get; init; }
}
