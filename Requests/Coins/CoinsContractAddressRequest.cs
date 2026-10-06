namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsContractAddress operation.
/// </summary>
public sealed record CoinsContractAddressRequest
{
    /// <summary>
    /// Asset platform ID.
    /// *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.
    /// </summary>
    public string Id { get; init; } = "ethereum";

    /// <summary>
    /// The contract address of token.
    /// </summary>
    public string ContractAddress { get; init; } = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2";
}
