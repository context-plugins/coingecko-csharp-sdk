using System;
using System.Collections.Generic;
using CoinGecko.Core.Configuration;
using CoinGecko.Core.Hooks;
using CoinGecko.Servers;

namespace CoinGecko;

public class CoinGeckoClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    /// <summary>
    /// Learn how to <see href="https://docs.coingecko.com/docs/setting-up-your-api-key">set up your API key</see>
    /// </summary>
    public string? HeaderAuth { get; set; }
    /// <summary>
    /// Learn how to <see href="https://docs.coingecko.com/docs/setting-up-your-api-key">set up your API key</see>
    /// </summary>
    public string? QueryAuth { get; set; }
}
