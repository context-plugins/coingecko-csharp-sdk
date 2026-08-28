using System.Collections.Generic;
using CoinGeckoDemoApi.Core.Configuration;
using CoinGeckoDemoApi.Core.Hooks;
using CoinGeckoDemoApi.Servers;

namespace CoinGeckoDemoApi;

public class CoinGeckoDemoApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
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
