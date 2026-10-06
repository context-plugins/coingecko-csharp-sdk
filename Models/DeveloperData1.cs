using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

/// <summary>
/// Developer data
/// </summary>
public record DeveloperData1
{
    /// <summary>
    /// Repository forks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forks")]
    public double? Forks { get; init; }

    /// <summary>
    /// Repository stars
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stars")]
    public double? Stars { get; init; }

    /// <summary>
    /// Repository subscribers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscribers")]
    public double? Subscribers { get; init; }

    /// <summary>
    /// Repository total issues
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_issues")]
    public double? TotalIssues { get; init; }

    /// <summary>
    /// Repository closed issues
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closed_issues")]
    public double? ClosedIssues { get; init; }

    /// <summary>
    /// Repository pull requests merged
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pull_requests_merged")]
    public double? PullRequestsMerged { get; init; }

    /// <summary>
    /// Repository pull request contributors
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pull_request_contributors")]
    public double? PullRequestContributors { get; init; }

    /// <summary>
    /// Code additions and deletions in 4 weeks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code_additions_deletions_4_weeks")]
    public CodeAdditionsDeletions4Weeks1? CodeAdditionsDeletions4Weeks { get; init; }

    /// <summary>
    /// Repository commit count in 4 weeks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commit_count_4_weeks")]
    public double? CommitCount4Weeks { get; init; }

    /// <summary>
    /// Repository last 4 weeks commit activity series
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_4_weeks_commit_activity_series")]
    public IReadOnlyList<double>? Last4WeeksCommitActivitySeries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
