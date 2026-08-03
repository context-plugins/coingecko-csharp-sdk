using Microsoft.Extensions.Logging;

namespace CoinGeckoDemoApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
