using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record Data1
{
    /// <summary>
    /// DeFi market cap
    /// </summary>
    [JsonPropertyName("defi_market_cap")]
    public required string DefiMarketCap { get; init; }

    /// <summary>
    /// ETH market cap
    /// </summary>
    [JsonPropertyName("eth_market_cap")]
    public required string EthMarketCap { get; init; }

    /// <summary>
    /// DeFi to ETH ratio
    /// </summary>
    [JsonPropertyName("defi_to_eth_ratio")]
    public required string DefiToEthRatio { get; init; }

    /// <summary>
    /// DeFi trading volume in 24 hours
    /// </summary>
    [JsonPropertyName("trading_volume_24h")]
    public required string TradingVolume24H { get; init; }

    /// <summary>
    /// DeFi dominance percentage
    /// </summary>
    [JsonPropertyName("defi_dominance")]
    public required string DefiDominance { get; init; }

    /// <summary>
    /// DeFi top coin name
    /// </summary>
    [JsonPropertyName("top_coin_name")]
    public required string TopCoinName { get; init; }

    /// <summary>
    /// DeFi top coin dominance percentage
    /// </summary>
    [JsonPropertyName("top_coin_defi_dominance")]
    public required double TopCoinDefiDominance { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
