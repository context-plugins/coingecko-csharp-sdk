namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the DexesList operation.
/// </summary>
public sealed record DexesListRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }
}
