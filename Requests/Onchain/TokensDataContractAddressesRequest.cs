using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the TokensDataContractAddresses operation.
/// </summary>
public sealed record TokensDataContractAddressesRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "solana";

    /// <summary>
    /// Token contract address, comma-separated if more than one token contract address.
    /// </summary>
    public string Addresses { get; init; } = "6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump";

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
    /// Include tokens from inactive pools using the most recent swap.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeInactiveSource { get; init; }
}
