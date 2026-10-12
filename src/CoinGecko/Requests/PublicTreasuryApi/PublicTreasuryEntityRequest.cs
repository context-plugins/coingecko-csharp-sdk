namespace CoinGecko.Requests.PublicTreasuryApi;

/// <summary>
/// The inputs of the PublicTreasuryEntity operation.
/// </summary>
public sealed record PublicTreasuryEntityRequest
{
    /// <summary>
    /// Public company or government entity ID.
    /// *refers to <see href="/reference/entities-list"><c>/entities/list</c></see>.
    /// </summary>
    public string EntityId { get; init; } = "strategy";

    /// <summary>
    /// Include holding amount change for specified timeframes, comma-separated if querying more than 1 timeframe.
    /// Valid values: <c>7d</c>, <c>14d</c>, <c>30d</c>, <c>90d</c>, <c>1y</c>, <c>ytd</c>
    /// </summary>
    public string? HoldingAmountChange { get; init; }

    /// <summary>
    /// Include holding change percentage for specified timeframes, comma-separated if querying more than 1 timeframe.
    /// Valid values: <c>7d</c>, <c>14d</c>, <c>30d</c>, <c>90d</c>, <c>1y</c>, <c>ytd</c>
    /// </summary>
    public string? HoldingChangePercentage { get; init; }
}
