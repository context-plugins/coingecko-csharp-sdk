using System.Net.Http;
using CoinGeckoDemoApi.Api;
using CoinGeckoDemoApi.Core;
using CoinGeckoDemoApi.Core.Logging;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi;

public sealed class CoinGeckoDemoApiClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public CoinGeckoDemoApiClient(HttpClient httpClient, CoinGeckoDemoApiClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
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
        _rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        _auth = new AuthSchemes(options);
    }

    /// <summary>
    /// Coin lists, market data, details, history, charts and OHLC
    /// </summary>
    public Coins Coins => field ??= new Coins(_rawClient, _server, _auth);

    /// <summary>
    /// Derivatives exchanges and tickers
    /// </summary>
    public Derivatives Derivatives => field ??= new Derivatives(_rawClient, _server, _auth);

    /// <summary>
    /// Entity directory and per-entity holdings
    /// </summary>
    public Entities Entities => field ??= new Entities(_rawClient, _server, _auth);

    /// <summary>
    /// Exchange lists, details, tickers, volume charts and BTC exchange rates
    /// </summary>
    public Exchanges Exchanges => field ??= new Exchanges(_rawClient, _server, _auth);

    /// <summary>
    /// Global crypto market data and DeFi stats
    /// </summary>
    public GlobalApi GlobalApi => field ??= new GlobalApi(_rawClient, _server, _auth);

    /// <summary>
    /// Ping, asset platforms and token lists
    /// </summary>
    public Misc Misc => field ??= new Misc(_rawClient, _server, _auth);

    /// <summary>
    /// NFT collection lists and details
    /// </summary>
    public Nfts Nfts => field ??= new Nfts(_rawClient, _server, _auth);

    /// <summary>
    /// On-chain DEX data (GeckoTerminal): networks, pools, tokens and OHLCV
    /// </summary>
    public Onchain Onchain => field ??= new Onchain(_rawClient, _server, _auth);

    /// <summary>
    /// Public companies and entities holding crypto treasuries
    /// </summary>
    public PublicTreasuryApi PublicTreasuryApi => field ??= new PublicTreasuryApi(_rawClient, _server, _auth);

    /// <summary>
    /// Search and trending
    /// </summary>
    public SearchApi SearchApi => field ??= new SearchApi(_rawClient, _server, _auth);

    /// <summary>
    /// Simple price and supported vs-currencies
    /// </summary>
    public Simple Simple => field ??= new Simple(_rawClient, _server, _auth);
}
