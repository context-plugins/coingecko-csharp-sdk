using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsList operation.
/// </summary>
public sealed record CoinsListRequest
{
    /// <summary>
    /// Include platform and token's contract addresses.
    /// Default: false
    /// </summary>
    public bool? IncludePlatform { get; init; }

    /// <summary>
    /// Filter by status of coins.
    /// Default: active
    /// </summary>
    public Status? Status { get; init; }
}
