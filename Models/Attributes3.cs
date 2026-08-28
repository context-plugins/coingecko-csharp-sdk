using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Attributes3
{
    /// <summary>
    /// Block number of the trade
    /// </summary>
    [JsonPropertyName("block_number")]
    public required int BlockNumber { get; init; }

    /// <summary>
    /// Transaction hash
    /// </summary>
    [JsonPropertyName("tx_hash")]
    public required string TxHash { get; init; }

    /// <summary>
    /// Transaction sender address
    /// </summary>
    [JsonPropertyName("tx_from_address")]
    public required string TxFromAddress { get; init; }

    /// <summary>
    /// Amount of token sent
    /// </summary>
    [JsonPropertyName("from_token_amount")]
    public required string FromTokenAmount { get; init; }

    /// <summary>
    /// Amount of token received
    /// </summary>
    [JsonPropertyName("to_token_amount")]
    public required string ToTokenAmount { get; init; }

    /// <summary>
    /// Price of from-token in currency token
    /// </summary>
    [JsonPropertyName("price_from_in_currency_token")]
    public required string PriceFromInCurrencyToken { get; init; }

    /// <summary>
    /// Price of to-token in currency token
    /// </summary>
    [JsonPropertyName("price_to_in_currency_token")]
    public required string PriceToInCurrencyToken { get; init; }

    /// <summary>
    /// Price of from-token in USD
    /// </summary>
    [JsonPropertyName("price_from_in_usd")]
    public required string PriceFromInUsd { get; init; }

    /// <summary>
    /// Price of to-token in USD
    /// </summary>
    [JsonPropertyName("price_to_in_usd")]
    public required string PriceToInUsd { get; init; }

    /// <summary>
    /// Block timestamp
    /// </summary>
    [JsonPropertyName("block_timestamp")]
    public required string BlockTimestamp { get; init; }

    /// <summary>
    /// Trade kind (buy or sell)
    /// </summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; init; }

    /// <summary>
    /// Trade volume in USD
    /// </summary>
    [JsonPropertyName("volume_in_usd")]
    public required string VolumeInUsd { get; init; }

    /// <summary>
    /// From-token contract address
    /// </summary>
    [JsonPropertyName("from_token_address")]
    public required string FromTokenAddress { get; init; }

    /// <summary>
    /// To-token contract address
    /// </summary>
    [JsonPropertyName("to_token_address")]
    public required string ToTokenAddress { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
