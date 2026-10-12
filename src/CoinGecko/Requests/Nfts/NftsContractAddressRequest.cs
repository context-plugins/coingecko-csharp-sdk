namespace CoinGecko.Requests.Nfts;

/// <summary>
/// The inputs of the NftsContractAddress operation.
/// </summary>
public sealed record NftsContractAddressRequest
{
    /// <summary>
    /// Asset platform ID.
    /// *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.
    /// </summary>
    public string AssetPlatformId { get; init; } = "ethereum";

    /// <summary>
    /// Contract address of the NFT collection.
    /// </summary>
    public string ContractAddress { get; init; } = "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8";
}
