using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the TokenDataContractAddress operation.
/// </summary>
public sealed record TokenDataContractAddressRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "eth";

    /// <summary>
    /// Token contract address.
    /// </summary>
    public string Address { get; init; } = "0xdac17f958d2ee523a2206206994597c13d831ec7";

    /// <summary>
    /// Attributes to include.
    /// </summary>
    public Include? Include { get; init; }

    /// <summary>
    /// Include pool composition.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeComposition { get; init; }

    /// <summary>
    /// Include token data from inactive pools using the most recent swap.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeInactiveSource { get; init; }
}
