using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Attributes16
{
    /// <summary>
    /// Token prices keyed by contract address
    /// </summary>
    [JsonPropertyName("token_prices")]
    public required IReadOnlyDictionary<string, string> TokenPrices { get; init; }

    /// <summary>
    /// Market cap in USD keyed by contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("market_cap_usd")]
    public IReadOnlyDictionary<string, string>? MarketCapUsd { get; init; }

    /// <summary>
    /// 24hr volume in USD keyed by contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("h24_volume_usd")]
    public IReadOnlyDictionary<string, string>? H24VolumeUsd { get; init; }

    /// <summary>
    /// 24hr price change percentage keyed by contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("h24_price_change_percentage")]
    public IReadOnlyDictionary<string, string>? H24PriceChangePercentage { get; init; }

    /// <summary>
    /// Total reserve in USD keyed by contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_reserve_in_usd")]
    public IReadOnlyDictionary<string, string>? TotalReserveInUsd { get; init; }

    /// <summary>
    /// Last trade timestamp keyed by contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_trade_timestamp")]
    public IReadOnlyDictionary<string, string>? LastTradeTimestamp { get; init; }
}
