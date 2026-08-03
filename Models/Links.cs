using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Links
/// </summary>
public record Links
{
    /// <summary>
    /// Website URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homepage")]
    public IReadOnlyList<string>? Homepage { get; init; }

    /// <summary>
    /// Whitepaper URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whitepaper")]
    public string? Whitepaper { get; init; }

    /// <summary>
    /// Block explorer URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("blockchain_site")]
    public IReadOnlyList<string>? BlockchainSite { get; init; }

    /// <summary>
    /// Official forum URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("official_forum_url")]
    public IReadOnlyList<string>? OfficialForumUrl { get; init; }

    /// <summary>
    /// Chat URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chat_url")]
    public IReadOnlyList<string>? ChatUrl { get; init; }

    /// <summary>
    /// Announcement URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("announcement_url")]
    public IReadOnlyList<string>? AnnouncementUrl { get; init; }

    /// <summary>
    /// Snapshot URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("snapshot_url")]
    public string? SnapshotUrl { get; init; }

    /// <summary>
    /// Twitter handle
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twitter_screen_name")]
    public string? TwitterScreenName { get; init; }

    /// <summary>
    /// Facebook username
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facebook_username")]
    public string? FacebookUsername { get; init; }

    /// <summary>
    /// Bitcointalk thread identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bitcointalk_thread_identifier")]
    public int? BitcointalkThreadIdentifier { get; init; }

    /// <summary>
    /// Telegram channel identifier
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telegram_channel_identifier")]
    public string? TelegramChannelIdentifier { get; init; }

    /// <summary>
    /// Subreddit URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subreddit_url")]
    public string? SubredditUrl { get; init; }

    /// <summary>
    /// Repository URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repos_url")]
    public ReposUrl? ReposUrl { get; init; }
}
