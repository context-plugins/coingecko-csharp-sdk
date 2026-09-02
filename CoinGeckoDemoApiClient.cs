using System.Net.Http;
using CoinGeckoDemoApi.Api;
using CoinGeckoDemoApi.Core;
using CoinGeckoDemoApi.Core.Logging;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi;

public sealed class CoinGeckoDemoApiClient
{
    public CoinGeckoDemoApiClient(HttpClient httpClient, CoinGeckoDemoApiClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "CoinGeckoDemoApiClient/3.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "3.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "CoinGeckoDemoApiClient");
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        var auth = new AuthSchemes(options);
        Coins = new Coins(rawClient, server, auth);
        Derivatives = new Derivatives(rawClient, server, auth);
        Entities = new Entities(rawClient, server, auth);
        Exchanges = new Exchanges(rawClient, server, auth);
        GlobalApi = new GlobalApi(rawClient, server, auth);
        Misc = new Misc(rawClient, server, auth);
        Nfts = new Nfts(rawClient, server, auth);
        Onchain = new Onchain(rawClient, server, auth);
        PublicTreasuryApi = new PublicTreasuryApi(rawClient, server, auth);
        SearchApi = new SearchApi(rawClient, server, auth);
        Simple = new Simple(rawClient, server, auth);
    }

    /// <summary>
    /// Coin lists, market data, details, history, charts and OHLC
    /// </summary>
    public Coins Coins { get; }

    /// <summary>
    /// Derivatives exchanges and tickers
    /// </summary>
    public Derivatives Derivatives { get; }

    /// <summary>
    /// Entity directory and per-entity holdings
    /// </summary>
    public Entities Entities { get; }

    /// <summary>
    /// Exchange lists, details, tickers, volume charts and BTC exchange rates
    /// </summary>
    public Exchanges Exchanges { get; }

    /// <summary>
    /// Global crypto market data and DeFi stats
    /// </summary>
    public GlobalApi GlobalApi { get; }

    /// <summary>
    /// Ping, asset platforms and token lists
    /// </summary>
    public Misc Misc { get; }

    /// <summary>
    /// NFT collection lists and details
    /// </summary>
    public Nfts Nfts { get; }

    /// <summary>
    /// On-chain DEX data (GeckoTerminal): networks, pools, tokens and OHLCV
    /// </summary>
    public Onchain Onchain { get; }

    /// <summary>
    /// Public companies and entities holding crypto treasuries
    /// </summary>
    public PublicTreasuryApi PublicTreasuryApi { get; }

    /// <summary>
    /// Search and trending
    /// </summary>
    public SearchApi SearchApi { get; }

    /// <summary>
    /// Simple price and supported vs-currencies
    /// </summary>
    public Simple Simple { get; }
}
