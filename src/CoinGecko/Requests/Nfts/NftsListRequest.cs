using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Nfts;

/// <summary>
/// The inputs of the NftsList operation.
/// </summary>
public sealed record NftsListRequest
{
    /// <summary>
    /// Sort order of responses.
    /// </summary>
    public Order7? Order { get; init; }

    /// <summary>
    /// Total results per page.
    /// Valid values: 1...250
    /// </summary>
    public int? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// </summary>
    public int? Page { get; init; }
}
