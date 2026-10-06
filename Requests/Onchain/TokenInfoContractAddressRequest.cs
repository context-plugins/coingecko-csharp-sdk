namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the TokenInfoContractAddress operation.
/// </summary>
public sealed record TokenInfoContractAddressRequest
{
    /// <summary>
    /// Network ID.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string Network { get; init; } = "solana";

    /// <summary>
    /// Token contract address.
    /// </summary>
    public string Address { get; init; } = "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump";
}
