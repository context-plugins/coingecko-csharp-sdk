using CoinGecko.Models.Enums;

namespace CoinGecko.Requests.Exchanges;

/// <summary>
/// The inputs of the ExchangesIdVolumeChart operation.
/// </summary>
public sealed record ExchangesIdVolumeChartRequest
{
    /// <summary>
    /// Exchange ID or derivative exchange ID.
    /// *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see> or <see href="/reference/derivatives-exchanges-list"><c>/derivatives/exchanges/list</c></see>.
    /// </summary>
    public string Id { get; init; } = "binance";

    /// <summary>
    /// Data up to number of days ago.
    /// </summary>
    public Days Days { get; init; } = Days._1;
}
