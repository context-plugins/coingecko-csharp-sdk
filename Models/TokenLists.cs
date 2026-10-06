using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

public record TokenLists
{
    /// <summary>
    /// Token list name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Token list logo URL
    /// </summary>
    [JsonPropertyName("logoURI")]
    public required string LogoUri { get; init; }

    /// <summary>
    /// Token list keywords
    /// </summary>
    [JsonPropertyName("keywords")]
    public required IReadOnlyList<string> Keywords { get; init; }

    /// <summary>
    /// Token list generation timestamp
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// List of tokens
    /// </summary>
    [JsonPropertyName("tokens")]
    public required IReadOnlyList<Token> Tokens { get; init; }

    /// <summary>
    /// Token list version
    /// </summary>
    [JsonPropertyName("version")]
    public required VersionModel Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
