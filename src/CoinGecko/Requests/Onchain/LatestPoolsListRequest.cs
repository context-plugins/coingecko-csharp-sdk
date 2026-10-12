namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the LatestPoolsList operation.
/// </summary>
public sealed record LatestPoolsListRequest
{
    /// <summary>
    /// Attributes to include, comma-separated if more than one.
    /// Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>, <c>network</c>
    /// </summary>
    public string? Include { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Include GeckoTerminal community data (sentiment votes, suspicious reports).
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeGtCommunityData { get; init; }
}
