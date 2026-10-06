using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Exchanges;

/// <summary>
/// The inputs of the ExchangesId operation.
/// </summary>
public sealed record ExchangesIdRequest
{
    /// <summary>
    /// Exchange ID.
    /// *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "binance";

    /// <summary>
    /// Set to <c>symbol</c> to display DEX pair base and target as symbols.
    /// Default: <c>contract_address</c>
    /// </summary>
    public DexPairFormat? DexPairFormat { get; init; }
}
