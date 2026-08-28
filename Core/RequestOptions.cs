using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using CoinGeckoDemoApi.Core.Hooks;

namespace CoinGeckoDemoApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
