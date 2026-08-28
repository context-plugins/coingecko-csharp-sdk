using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

public record Attributes8
{
    /// <summary>
    /// Base token contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_token_address")]
    public string? BaseTokenAddress { get; init; }

    /// <summary>
    /// Quote token contract address
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_token_address")]
    public string? QuoteTokenAddress { get; init; }

    /// <summary>
    /// Quote token contract addresses, present for pools with more than 2 tokens
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_token_addresses")]
    public IReadOnlyList<string>? QuoteTokenAddresses { get; init; }

    /// <summary>
    /// GeckoTerminal community positive sentiment vote percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_vote_positive_percentage")]
    public double? SentimentVotePositivePercentage { get; init; }

    /// <summary>
    /// GeckoTerminal community negative sentiment vote percentage
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_vote_negative_percentage")]
    public double? SentimentVoteNegativePercentage { get; init; }

    /// <summary>
    /// GeckoTerminal community suspicious reports count
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("community_sus_report")]
    public int? CommunitySusReport { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
