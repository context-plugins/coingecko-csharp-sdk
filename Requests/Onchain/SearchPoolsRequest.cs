namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the SearchPools operation.
/// </summary>
public sealed record SearchPoolsRequest
{
    /// <summary>
    /// Search query: pool contract address, token name, token symbol, or token contract address.
    /// </summary>
    public string Query { get; init; } = "weth";

    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string? Network { get; init; }

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
}
