using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the PoolTokenInfoContractAddress operation.
/// </summary>
public sealed record PoolTokenInfoContractAddressRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "solana";

    /// <summary>
    /// Pool contract address.
    /// </summary>
    public string PoolAddress { get; init; } = "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt";

    /// <summary>
    /// Attributes to include.
    /// </summary>
    public Include2? Include { get; init; }
}
