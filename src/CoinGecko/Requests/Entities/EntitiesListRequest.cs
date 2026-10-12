using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Entities;

/// <summary>
/// The inputs of the EntitiesList operation.
/// </summary>
public sealed record EntitiesListRequest
{
    /// <summary>
    /// Filter by entity type.
    /// </summary>
    public EntityType? EntityType { get; init; }

    /// <summary>
    /// Total results per page.
    /// Default value: 100
    /// Valid values: 1...250
    /// </summary>
    public int? PerPage { get; init; }

    /// <summary>
    /// Page through results.
    /// Default value: 1
    /// </summary>
    public int? Page { get; init; }
}
