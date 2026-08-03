using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// Repository URL
/// </summary>
public record ReposUrl
{
    /// <summary>
    /// GitHub repository URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("github")]
    public IReadOnlyList<string>? Github { get; init; }

    /// <summary>
    /// Bitbucket repository URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bitbucket")]
    public IReadOnlyList<string>? Bitbucket { get; init; }
}
