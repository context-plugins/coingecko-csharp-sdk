namespace CoinGecko.Requests.Misc;

/// <summary>
/// The inputs of the TokenLists operation.
/// </summary>
public sealed record TokenListsRequest
{
    /// <summary>
    /// Asset platform ID.
    /// *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.
    /// </summary>
    public string AssetPlatformId { get; init; } = "ethereum";
}
