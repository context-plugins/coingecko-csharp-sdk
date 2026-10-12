using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Misc;

/// <summary>
/// The inputs of the AssetPlatformsList operation.
/// </summary>
public sealed record AssetPlatformsListRequest
{
    /// <summary>
    /// Apply relevant filters to results.
    /// </summary>
    public Filter? Filter { get; init; }
}
