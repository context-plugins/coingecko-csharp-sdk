namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsIdHistory operation.
/// </summary>
public sealed record CoinsIdHistoryRequest
{
    /// <summary>
    /// Coin ID.
    /// *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "bitcoin";

    /// <summary>
    /// The date of data snapshot.
    /// Format: <c>dd-mm-yyyy</c>
    /// </summary>
    public string Date { get; init; } = "30-12-2025";

    /// <summary>
    /// Include all the localized languages in response.
    /// Default: true
    /// </summary>
    public bool? Localization { get; init; }
}
