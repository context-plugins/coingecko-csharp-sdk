using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Exchanges;

/// <summary>
/// The inputs of the ExchangesIdTickers operation.
/// </summary>
public sealed record ExchangesIdTickersRequest
{
    /// <summary>
    /// Exchange ID.
    /// *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "binance";

    /// <summary>
    /// Filter tickers by coin IDs, comma-separated if querying more than 1 coin.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.
    /// </summary>
    public string? CoinIds { get; init; }

    /// <summary>
    /// Include exchange logo.
    /// Default: false
    /// </summary>
    public bool? IncludeExchangeLogo { get; init; }

    /// <summary>
    /// Page through results.
    /// </summary>
    public double? Page { get; init; }

    /// <summary>
    /// Include 2% orderbook depth (cost_to_move_up_usd and cost_to_move_down_usd).
    /// Default: false
    /// </summary>
    public bool? Depth { get; init; }

    /// <summary>
    /// Sort the order of responses.
    /// Default: <c>trust_score_desc</c>
    /// </summary>
    public Order3? Order { get; init; }

    /// <summary>
    /// Set to <c>symbol</c> to display DEX pair base and target as symbols.
    /// Default: <c>contract_address</c>
    /// </summary>
    public DexPairFormat? DexPairFormat { get; init; }
}
