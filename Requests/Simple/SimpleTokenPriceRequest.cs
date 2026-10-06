using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Simple;

/// <summary>
/// The inputs of the SimpleTokenPrice operation.
/// </summary>
public sealed record SimpleTokenPriceRequest
{
    /// <summary>
    /// Asset platform's ID.
    /// *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>
    /// </summary>
    public string Id { get; init; } = "ethereum";

    /// <summary>
    /// Token contract addresses, comma-separated if querying more than 1 token
    /// </summary>
    public string ContractAddresses { get; init; } = "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599";

    /// <summary>
    /// Target currency of coins, comma-separated if querying more than 1 currency.
    /// *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>
    /// </summary>
    public string VsCurrencies { get; init; } = "usd";

    /// <summary>
    /// Include market capitalization.
    /// Default: false
    /// </summary>
    public bool? IncludeMarketCap { get; init; }

    /// <summary>
    /// Include 24-hour trading volume.
    /// Default: false
    /// </summary>
    public bool? Include24HrVol { get; init; }

    /// <summary>
    /// Include 24-hour change percentage.
    /// Default: false
    /// </summary>
    public bool? Include24HrChange { get; init; }

    /// <summary>
    /// Include last updated price time as a UNIX timestamp.
    /// Default: false
    /// </summary>
    public bool? IncludeLastUpdatedAt { get; init; }

    /// <summary>
    /// Decimal places for currency price value
    /// </summary>
    public Precision? Precision { get; init; }
}
