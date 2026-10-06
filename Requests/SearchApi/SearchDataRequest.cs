namespace CoinGecko.Requests.SearchApi;

/// <summary>
/// The inputs of the SearchData operation.
/// </summary>
public sealed record SearchDataRequest
{
    /// <summary>
    /// Search query
    /// </summary>
    public required string Query { get; init; }
}
