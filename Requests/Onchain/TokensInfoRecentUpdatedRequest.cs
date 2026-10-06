using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Onchain;

/// <summary>
/// The inputs of the TokensInfoRecentUpdated operation.
/// </summary>
public sealed record TokensInfoRecentUpdatedRequest
{
    /// <summary>
    /// Attributes for related resources to include.
    /// </summary>
    public Include3? Include { get; init; }

    /// <summary>
    /// Filter tokens by provided network.
    /// *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.
    /// </summary>
    public string? Network { get; init; }
}
