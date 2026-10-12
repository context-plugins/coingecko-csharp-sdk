using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the TopPoolsContractAddress operation.
/// </summary>
public sealed record TopPoolsContractAddressRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Token contract address.
    /// </summary>
    public string TokenAddress { get; init; } = "0xdac17f958d2ee523a2206206994597c13d831ec7";

    /// <summary>
    /// Attributes to include, comma-separated if more than one.
    /// Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>
    /// </summary>
    public string? Include { get; init; }

    /// <summary>
    /// Include tokens from inactive pools using the most recent swap.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeInactiveSource { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Sort the pools by field.
    /// Default: <c>h24_volume_usd_liquidity_desc</c>
    /// </summary>
    public Sort2? Sort { get; init; }

    /// <summary>
    /// Include GeckoTerminal community data (sentiment votes, suspicious reports).
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeGtCommunityData { get; init; }
}
