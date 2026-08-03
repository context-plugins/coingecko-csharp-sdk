using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Community engagement data
/// </summary>
public record CommunityData
{
    /// <summary>
    /// Number of Facebook likes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facebook_likes")]
    public double? FacebookLikes { get; init; }

    /// <summary>
    /// Average Reddit posts in 48 hours
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_average_posts_48h")]
    public double? RedditAveragePosts48H { get; init; }

    /// <summary>
    /// Average Reddit comments in 48 hours
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_average_comments_48h")]
    public double? RedditAverageComments48H { get; init; }

    /// <summary>
    /// Number of Reddit subscribers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_subscribers")]
    public double? RedditSubscribers { get; init; }

    /// <summary>
    /// Active Reddit accounts in 48 hours
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_accounts_active_48h")]
    public double? RedditAccountsActive48H { get; init; }
}
