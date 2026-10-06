using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Coins;

/// <summary>
/// The inputs of the CoinsCategories operation.
/// </summary>
public sealed record CoinsCategoriesRequest
{
    /// <summary>
    /// Sort results by field.
    /// Default: <c>market_cap_desc</c>
    /// </summary>
    public Order2? Order { get; init; }
}
