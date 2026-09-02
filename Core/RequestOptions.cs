using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using CoinGecko.Core.Hooks;

namespace CoinGecko.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
