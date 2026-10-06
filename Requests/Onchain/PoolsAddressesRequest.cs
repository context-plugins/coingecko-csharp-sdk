namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the PoolsAddresses operation.
/// </summary>
public sealed record PoolsAddressesRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Pool contract address, comma-separated if more than one pool contract address.
    /// </summary>
    public string Addresses { get; init; } = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640";

    /// <summary>
    /// Attributes to include, comma-separated if more than one.
    /// Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>
    /// </summary>
    public string? Include { get; init; }

    /// <summary>
    /// Include volume breakdown.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeVolumeBreakdown { get; init; }

    /// <summary>
    /// Include pool composition.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeComposition { get; init; }
}
