namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the NetworksList operation.
/// </summary>
public sealed record NetworksListRequest
{
    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }
}
