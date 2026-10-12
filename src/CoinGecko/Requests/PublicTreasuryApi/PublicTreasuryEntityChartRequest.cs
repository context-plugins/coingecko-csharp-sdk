namespace CoinGecko.Requests.PublicTreasuryApi;

/// <summary>
/// The inputs of the PublicTreasuryEntityChart operation.
/// </summary>
public sealed record PublicTreasuryEntityChartRequest
{
    /// <summary>
    /// Public company or government entity ID.
    /// *refers to <see href="/reference/entities-list"><c>/entities/list</c></see>.
    /// </summary>
    public string EntityId { get; init; } = "strategy";

    /// <summary>
    /// Coin ID.
    /// e.g. <c>bitcoin</c>, <c>ethereum</c>, <c>solana</c>, <c>binancecoin</c>
    /// </summary>
    public string CoinId { get; init; } = "bitcoin";

    /// <summary>
    /// Data up to number of days ago.
    /// Valid values: <c>7</c>, <c>14</c>, <c>30</c>, <c>90</c>, <c>180</c>, <c>365</c>
    /// </summary>
    public string Days { get; init; } = "365";

    /// <summary>
    /// Include empty intervals with no transaction data.
    /// Default: <c>false</c>
    /// </summary>
    public bool? IncludeEmptyIntervals { get; init; }
}
