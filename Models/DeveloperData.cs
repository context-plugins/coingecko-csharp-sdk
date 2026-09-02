using System.Text.Json.Serialization;
using CoinGecko.Core.Models;

namespace CoinGecko.Models;

/// <summary>
/// Developer activity data
/// </summary>
public record DeveloperData
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
    /// Total issues
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_issues")]
    public double? TotalIssues { get; init; }

    /// <summary>
    /// Closed issues
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closed_issues")]
    public double? ClosedIssues { get; init; }

    /// <summary>
    /// Pull requests merged
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pull_requests_merged")]
    public double? PullRequestsMerged { get; init; }

    /// <summary>
    /// Pull request contributors
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pull_request_contributors")]
    public double? PullRequestContributors { get; init; }

    /// <summary>
    /// Code additions and deletions in the last 4 weeks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code_additions_deletions_4_weeks")]
    public CodeAdditionsDeletions4Weeks? CodeAdditionsDeletions4Weeks { get; init; }

    /// <summary>
    /// Commit count in the last 4 weeks
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commit_count_4_weeks")]
    public double? CommitCount4Weeks { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
