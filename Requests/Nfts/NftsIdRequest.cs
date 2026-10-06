namespace CoinGecko.Requests.Nfts;

/// <summary>
/// The inputs of the NftsId operation.
/// </summary>
public sealed record NftsIdRequest
{
    /// <summary>
    /// NFT collection ID.
    /// *refers to <see href="/reference/nfts-list"><c>/nfts/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "pudgy-penguins";
}
