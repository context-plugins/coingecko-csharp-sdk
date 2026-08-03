using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Community data
/// </summary>
public record CommunityData1
{
    /// <summary>
    /// Facebook likes
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facebook_likes")]
    public double? FacebookLikes { get; init; }

    /// <summary>
    /// Reddit average posts in 48 hours
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_average_posts_48h")]
    public double? RedditAveragePosts48H { get; init; }

    /// <summary>
    /// Reddit average comments in 48 hours
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_average_comments_48h")]
    public double? RedditAverageComments48H { get; init; }

    /// <summary>
    /// Reddit subscribers
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_subscribers")]
    public double? RedditSubscribers { get; init; }

    /// <summary>
    /// Reddit active accounts in 48 hours
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reddit_accounts_active_48h")]
    public double? RedditAccountsActive48H { get; init; }

    /// <summary>
    /// Telegram channel user count
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telegram_channel_user_count")]
    public double? TelegramChannelUserCount { get; init; }
}
