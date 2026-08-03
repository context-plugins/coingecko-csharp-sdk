using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoinGeckoDemoApi.Core;
using CoinGeckoDemoApi.Core.Authentication;
using CoinGeckoDemoApi.Core.ErrorResponse;
using CoinGeckoDemoApi.Core.Exceptions;
using CoinGeckoDemoApi.Core.Logging;
using CoinGeckoDemoApi.Core.Models;
using CoinGeckoDemoApi.Core.Request;
using CoinGeckoDemoApi.Core.Response;
using CoinGeckoDemoApi.Models;
using CoinGeckoDemoApi.Models.AnyOf;
using CoinGeckoDemoApi.Models.Enums;

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
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        _auth = new AuthSchemes(options);
    }

    /// <summary>
    /// Asset Platforms List
    /// </summary>
    /// <param name="filter">Apply relevant filters to results.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="AssetPlatform"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported asset platforms (blockchain networks) on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<AssetPlatform>> AssetPlatformsList(Filter? filter,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/asset_platforms"),
            [],
            [new Param("filter", filter)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<AssetPlatform>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coins Categories List with Market Data
    /// </summary>
    /// <param name="order">Sort results by field.  Default: <c>market_cap_desc</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Category1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the coins categories with market data (market cap, volume, etc.) on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<Category1>> CoinsCategories(Order2? order,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/categories"),
            [],
            [new Param("order", order)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Category1>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coins Categories List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CategoriesList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported coins categories on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<CategoriesList>> CoinsCategoriesList(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/categories/list"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CategoriesList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Data by Token Address
    /// </summary>
    /// <param name="id">Asset platform ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.</param>
    /// <param name="contractAddress">The contract address of token.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsContractAddress"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the metadata (image, websites, socials, description, contract address, etc.) and market data (price, ATH, exchange tickers, etc.) of a coin based on an asset platform and a particular token contract address
    /// </remarks>
    public Task<CoinsContractAddress> CoinsContractAddress(string id = "ethereum",
        string contractAddress = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/contract/{contract_address}"),
            [new TemplateParam("id", id), new TemplateParam("contract_address", contractAddress)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsContractAddress>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Data by ID
    /// </summary>
    /// <param name="localization">Include all localized languages in the response.  Default: true</param>
    /// <param name="tickers">Include tickers data.  Default: true</param>
    /// <param name="marketData">Include market data.  Default: true</param>
    /// <param name="communityData">Include community data.  Default: true</param>
    /// <param name="developerData">Include developer data.  Default: true</param>
    /// <param name="sparkline">Include sparkline 7-day data.  Default: false</param>
    /// <param name="includeCategoriesDetails">Include categories details.  Default: false</param>
    /// <param name="dexPairFormat">Set to <c>symbol</c> to display DEX pair base and target as symbols.  Default: <c>contract_address</c></param>
    /// <param name="id">Coin ID.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsId"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the metadata (image, websites, socials, description, contract address, etc.) and market data (price, ATH, exchange tickers, etc.) of a coin based on a particular coin ID
    /// </remarks>
    public Task<CoinsId> CoinsId(bool? localization,
        bool? tickers,
        bool? marketData,
        bool? communityData,
        bool? developerData,
        bool? sparkline,
        bool? includeCategoriesDetails,
        DexPairFormat? dexPairFormat,
        string id = "bitcoin",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}"),
            [new TemplateParam("id", id)],
            [new Param("localization", localization),
                new Param("tickers", tickers),
                new Param("market_data", marketData),
                new Param("community_data", communityData),
                new Param("developer_data", developerData),
                new Param("sparkline", sparkline),
                new Param("include_categories_details", includeCategoriesDetails),
                new Param("dex_pair_format", dexPairFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsId>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Historical Data by ID
    /// </summary>
    /// <param name="localization">Include all the localized languages in response.  Default: true</param>
    /// <param name="id">Coin ID.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.</param>
    /// <param name="date">The date of data snapshot.  Format: <c>dd-mm-yyyy</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsIdHistory"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the historical data (price, market cap, 24hrs volume, etc.) at a given date for a coin based on a particular coin ID
    /// </remarks>
    public Task<CoinsIdHistory> CoinsIdHistory(bool? localization,
        string id = "bitcoin",
        string date = "30-12-2025",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/history"),
            [new TemplateParam("id", id)],
            [new Param("date", date), new Param("localization", localization)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsIdHistory>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Historical Chart Data by ID
    /// </summary>
    /// <param name="interval">Data interval, leave empty for auto granularity.</param>
    /// <param name="precision">Decimal place for currency price value.</param>
    /// <param name="id">Coin ID.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.</param>
    /// <param name="vsCurrency">Target currency of market data.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.</param>
    /// <param name="days">Data up to number of days ago.  You may use any integer or <c>max</c> for number of days.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data of a coin including time in UNIX, price, market cap and 24hrs volume based on particular coin ID
    /// </remarks>
    public Task<CoinsMarketChart> CoinsIdMarketChart(Interval? interval,
        Precision? precision,
        string id = "bitcoin",
        string vsCurrency = "usd",
        string days = "1",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/market_chart"),
            [new TemplateParam("id", id)],
            [new Param("vs_currency", vsCurrency),
                new Param("days", days),
                new Param("interval", interval),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Historical Chart Data within Time Range by ID
    /// </summary>
    /// <param name="precision">Decimal place for currency price value.</param>
    /// <param name="id">Coin ID.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.</param>
    /// <param name="vsCurrency">Target currency of market data.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.</param>
    /// <param name="from">Starting date in UNIX timestamp.</param>
    /// <param name="to">Ending date in UNIX timestamp.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data of a coin within certain time range in UNIX along with price, market cap and 24hrs volume based on particular coin ID
    /// </remarks>
    public Task<CoinsMarketChart> CoinsIdMarketChartRange(Precision? precision,
        string id = "bitcoin",
        string vsCurrency = "usd",
        int from = 1767024000,
        int to = 1777564800,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/market_chart/range"),
            [new TemplateParam("id", id)],
            [new Param("vs_currency", vsCurrency),
                new Param("from", from),
                new Param("to", to),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin OHLC Chart by ID
    /// </summary>
    /// <param name="days">Data up to number of days ago.</param>
    /// <param name="precision">Decimal place for currency price value.</param>
    /// <param name="id">Coin ID.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.</param>
    /// <param name="vsCurrency">Target currency of price data.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="double"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the OHLC chart (Open, High, Low, Close) of a coin based on particular coin ID
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<double>>> CoinsIdOhlc(Days days,
        Precision? precision,
        string id = "bitcoin",
        string vsCurrency = "usd",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/ohlc"),
            [new TemplateParam("id", id)],
            [new Param("vs_currency", vsCurrency), new Param("days", days), new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<double>>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Tickers by ID
    /// </summary>
    /// <param name="exchangeIds">Exchange ID.  *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see></param>
    /// <param name="includeExchangeLogo">Include exchange logo.  Default: false</param>
    /// <param name="page">Page through results</param>
    /// <param name="order">Sort the order of responses.  Default: trust_score_desc</param>
    /// <param name="depth">Include 2% orderbook depth, i.e. <c>cost_to_move_up_usd</c> and <c>cost_to_move_down_usd</c>.  Default: false</param>
    /// <param name="dexPairFormat">Set to <c>symbol</c> to display DEX pair base and target as symbols.  Default: <c>contract_address</c></param>
    /// <param name="id">Coin ID.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsIdTickers"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the coin tickers on both centralized exchange (CEX) and decentralized exchange (DEX) based on a particular coin ID
    /// </remarks>
    public Task<CoinsIdTickers> CoinsIdTickers(string? exchangeIds,
        bool? includeExchangeLogo,
        int? page,
        Order1? order,
        bool? depth,
        DexPairFormat? dexPairFormat,
        string id = "bitcoin",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/tickers"),
            [new TemplateParam("id", id)],
            [new Param("exchange_ids", exchangeIds),
                new Param("include_exchange_logo", includeExchangeLogo),
                new Param("page", page),
                new Param("order", order),
                new Param("depth", depth),
                new Param("dex_pair_format", dexPairFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsIdTickers>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coins List
    /// </summary>
    /// <param name="includePlatform">Include platform and token's contract addresses.  Default: false</param>
    /// <param name="status">Filter by status of coins.  Default: active</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CoinsList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported coins on CoinGecko with coin ID, name and symbol
    /// </remarks>
    public Task<IReadOnlyList<CoinsList>> CoinsList(bool? includePlatform,
        Status? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/list"),
            [],
            [new Param("include_platform", includePlatform), new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CoinsList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coins List with Market Data
    /// </summary>
    /// <param name="includeTokens">For <c>symbols</c> lookups, specify <c>all</c> to include all matching tokens.  Default <c>top</c> returns top-ranked tokens by market cap or volume.</param>
    /// <param name="category">Filter based on coins' category.  *refers to <see href="/reference/coins-categories-list"><c>/coins/categories/list</c></see></param>
    /// <param name="order">Sort result by field.  Default: market_cap_desc</param>
    /// <param name="perPage">Total results per page.  Default: 100  Valid values: 1...250</param>
    /// <param name="page">Page through results.  Default: 1</param>
    /// <param name="sparkline">Include sparkline 7-day data.  Default: false</param>
    /// <param name="priceChangePercentage">Include price change percentage timeframe, comma-separated if querying more than 1 timeframe.  Valid values: <c>1h</c>, <c>24h</c>, <c>7d</c>, <c>14d</c>, <c>30d</c>, <c>200d</c>, <c>1y</c></param>
    /// <param name="locale">Language background.  Default: en</param>
    /// <param name="precision">Decimal places for currency price value</param>
    /// <param name="includeRehypothecated">Include rehypothecated tokens in results. When true, returns <c>market_cap_rank_with_rehypothecated</c> field.  Default: false</param>
    /// <param name="vsCurrency">Target currency of coins and market data.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see></param>
    /// <param name="ids">Coins' IDs, comma-separated if querying more than 1 coin.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see></param>
    /// <param name="names">Coins' names, comma-separated if querying more than 1 coin.</param>
    /// <param name="symbols">Coins' symbols, comma-separated if querying more than 1 coin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CoinsMarket"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported coins with price, market cap, volume and market related data
    /// </remarks>
    public Task<IReadOnlyList<CoinsMarket>> CoinsMarkets(IncludeTokens? includeTokens,
        string? category,
        Order? order,
        int? perPage,
        int? page,
        bool? sparkline,
        string? priceChangePercentage,
        Locale? locale,
        Precision? precision,
        bool? includeRehypothecated,
        string vsCurrency = "usd",
        string? ids = "bitcoin",
        string? names = "Bitcoin",
        string? symbols = "btc",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/markets"),
            [],
            [new Param("vs_currency", vsCurrency),
                new Param("ids", ids),
                new Param("names", names),
                new Param("symbols", symbols),
                new Param("include_tokens", includeTokens),
                new Param("category", category),
                new Param("order", order),
                new Param("per_page", perPage),
                new Param("page", page),
                new Param("sparkline", sparkline),
                new Param("price_change_percentage", priceChangePercentage),
                new Param("locale", locale),
                new Param("precision", precision),
                new Param("include_rehypothecated", includeRehypothecated)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CoinsMarket>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Treasury Holdings by Coin ID
    /// </summary>
    /// <param name="entity">Public company or government entity.</param>
    /// <param name="perPage">Total results per page.  Default value: 250  Valid values: 1...250</param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="order">Sort order for results.  Default: <c>total_holdings_usd_desc</c></param>
    /// <param name="coinId">Coin ID.  e.g. <c>bitcoin</c>, <c>ethereum</c>, <c>solana</c>, <c>binancecoin</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasury"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query public companies' and governments' cryptocurrency holdings by coin ID
    /// </remarks>
    public Task<PublicTreasury> CompaniesPublicTreasury(Entity entity,
        int? perPage,
        int? page,
        Order5? order,
        string coinId = "bitcoin",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/{entity}/public_treasury/{coin_id}"),
            [new TemplateParam("entity", entity), new TemplateParam("coin_id", coinId)],
            [new Param("per_page", perPage), new Param("page", page), new Param("order", order)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasury>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Historical Chart Data by Token Address
    /// </summary>
    /// <param name="interval">Data interval, leave empty for auto granularity.</param>
    /// <param name="precision">Decimal place for currency price value.</param>
    /// <param name="id">Asset platform ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.</param>
    /// <param name="contractAddress">The contract address of token.</param>
    /// <param name="vsCurrency">Target currency of market data.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.</param>
    /// <param name="days">Data up to number of days ago.  You may use any integer or <c>max</c> for number of days.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data including time in UNIX, price, market cap and 24hrs volume based on asset platform and particular token contract address
    /// </remarks>
    public Task<CoinsMarketChart> ContractAddressMarketChart(Interval? interval,
        Precision? precision,
        string id = "ethereum",
        string contractAddress = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48",
        string vsCurrency = "usd",
        string days = "1",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/contract/{contract_address}/market_chart"),
            [new TemplateParam("id", id), new TemplateParam("contract_address", contractAddress)],
            [new Param("vs_currency", vsCurrency),
                new Param("days", days),
                new Param("interval", interval),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Historical Chart Data within Time Range by Token Address
    /// </summary>
    /// <param name="precision">Decimal place for currency price value.</param>
    /// <param name="id">Asset platform ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.</param>
    /// <param name="contractAddress">The contract address of token.</param>
    /// <param name="vsCurrency">Target currency of market data.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see>.</param>
    /// <param name="from">Starting date in UNIX timestamp.</param>
    /// <param name="to">Ending date in UNIX timestamp.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data within certain time range in UNIX along with price, market cap and 24hrs volume based on asset platform and particular token contract address
    /// </remarks>
    public Task<CoinsMarketChart> ContractAddressMarketChartRange(Precision? precision,
        string id = "ethereum",
        string contractAddress = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48",
        string vsCurrency = "usd",
        int from = 1767024000,
        int to = 1777564800,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/coins/{id}/contract/{contract_address}/market_chart/range"),
            [new TemplateParam("id", id), new TemplateParam("contract_address", contractAddress)],
            [new Param("vs_currency", vsCurrency),
                new Param("from", from),
                new Param("to", to),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Global Market Data
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Global"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query cryptocurrency global data including active cryptocurrencies, markets, total crypto market cap and etc
    /// </remarks>
    public Task<Global> CryptoGlobal(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/global"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Global>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Derivatives Exchanges List with Data
    /// </summary>
    /// <param name="order">Sort order of responses.  Default: <c>open_interest_btc_desc</c></param>
    /// <param name="perPage">Total results per page.</param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DerivativesExchange"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the derivatives exchanges with related data (ID, name, open interest, ...) on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<DerivativesExchange>> DerivativesExchanges(Order4? order,
        int? perPage,
        int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/derivatives/exchanges"),
            [],
            [new Param("order", order), new Param("per_page", perPage), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DerivativesExchange>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Derivatives Exchange Data by ID
    /// </summary>
    /// <param name="includeTickers">Include tickers data.  Default: tickers data is not included.</param>
    /// <param name="id">Derivative exchange ID.  *refers to <see href="/reference/derivatives-exchanges-list"><c>/derivatives/exchanges/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DerivativesExchangesId"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the derivatives exchange's related data (name, open interest, trade volume, ...) based on the exchange's ID
    /// </remarks>
    public Task<DerivativesExchangesId> DerivativesExchangesId(IncludeTickers? includeTickers,
        string id = "binance_futures",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/derivatives/exchanges/{id}"),
            [new TemplateParam("id", id)],
            [new Param("include_tickers", includeTickers)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DerivativesExchangesId>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Derivatives Exchanges List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DerivativesExchangesList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported derivatives exchanges with ID and name on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<DerivativesExchangesList>> DerivativesExchangesList(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/derivatives/exchanges/list"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DerivativesExchangesList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Derivatives Tickers List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="DerivativesTicker"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the tickers from derivatives exchanges on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<DerivativesTicker>> DerivativesTickers(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/derivatives"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<DerivativesTicker>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// DEXs List by Network
    /// </summary>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DexesList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported decentralized exchanges (DEXs) based on the provided network on GeckoTerminal
    /// </remarks>
    public Task<DexesList> DexesList(int? page,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/dexes"),
            [new TemplateParam("network", network)],
            [new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DexesList>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Entities List
    /// </summary>
    /// <param name="entityType">Filter by entity type.</param>
    /// <param name="perPage">Total results per page.  Default value: 100  Valid values: 1...250</param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="EntitiesList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported entities on CoinGecko with entity ID, name, symbol, and country
    /// </remarks>
    public Task<IReadOnlyList<EntitiesList>> EntitiesList(EntityType? entityType,
        int? perPage,
        int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/entities/list"),
            [],
            [new Param("entity_type", entityType), new Param("per_page", perPage), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<EntitiesList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// BTC-to-Currency Exchange Rates
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ExchangeRates"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query BTC exchange rates with other currencies
    /// </remarks>
    public Task<ExchangeRates> ExchangeRates(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/exchange_rates"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ExchangeRates>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Exchanges List with Data
    /// </summary>
    /// <param name="perPage">Total results per page.  Default: 100.  Valid values: 1...250</param>
    /// <param name="page">Page through results.  Default: 1</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Exchange1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported exchanges with exchanges' data (ID, name, country, etc.) that have active trading volumes on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<Exchange1>> Exchanges(double? perPage,
        double? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/exchanges"),
            [],
            [new Param("per_page", perPage), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Exchange1>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Exchange Data by ID
    /// </summary>
    /// <param name="dexPairFormat">Set to <c>symbol</c> to display DEX pair base and target as symbols.  Default: <c>contract_address</c></param>
    /// <param name="id">Exchange ID.  *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ExchangesId"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query exchange's data (name, year established, country, etc.), exchange volume in BTC and top 100 tickers based on exchange's ID
    /// </remarks>
    public Task<ExchangesId> ExchangesId(DexPairFormat? dexPairFormat,
        string id = "binance",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/exchanges/{id}"),
            [new TemplateParam("id", id)],
            [new Param("dex_pair_format", dexPairFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ExchangesId>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Exchange Tickers by ID
    /// </summary>
    /// <param name="coinIds">Filter tickers by coin IDs, comma-separated if querying more than 1 coin.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.</param>
    /// <param name="includeExchangeLogo">Include exchange logo.  Default: false</param>
    /// <param name="page">Page through results.</param>
    /// <param name="depth">Include 2% orderbook depth (cost_to_move_up_usd and cost_to_move_down_usd).  Default: false</param>
    /// <param name="order">Sort the order of responses.  Default: <c>trust_score_desc</c></param>
    /// <param name="dexPairFormat">Set to <c>symbol</c> to display DEX pair base and target as symbols.  Default: <c>contract_address</c></param>
    /// <param name="id">Exchange ID.  *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsIdTickers"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query exchange's tickers based on exchange's ID
    /// </remarks>
    public Task<CoinsIdTickers> ExchangesIdTickers(string? coinIds,
        bool? includeExchangeLogo,
        double? page,
        bool? depth,
        Order3? order,
        DexPairFormat? dexPairFormat,
        string id = "binance",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/exchanges/{id}/tickers"),
            [new TemplateParam("id", id)],
            [new Param("coin_ids", coinIds),
                new Param("include_exchange_logo", includeExchangeLogo),
                new Param("page", page),
                new Param("depth", depth),
                new Param("order", order),
                new Param("dex_pair_format", dexPairFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsIdTickers>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Exchange Volume Chart by ID
    /// </summary>
    /// <param name="days">Data up to number of days ago.</param>
    /// <param name="id">Exchange ID or derivative exchange ID.  *refers to <see href="/reference/exchanges-list"><c>/exchanges/list</c></see> or <see href="/reference/derivatives-exchanges-list"><c>/derivatives/exchanges/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ExchangeVolumeChart"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the historical volume chart data with time in UNIX and trading volume data in BTC based on exchange's ID
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>> ExchangesIdVolumeChart(Days days,
        string id = "binance",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/exchanges/{id}/volume_chart"),
            [new TemplateParam("id", id)],
            [new Param("days", days)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Exchanges List
    /// </summary>
    /// <param name="status">Filter by status of exchanges.  Default: <c>active</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="ExchangesList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported exchanges with ID and name
    /// </remarks>
    public Task<IReadOnlyList<ExchangesList>> ExchangesList(Status? status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/exchanges/list"),
            [],
            [new Param("status", status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<ExchangesList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Global DeFi Market Data
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GlobalDeFi"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query top 100 cryptocurrency global decentralized finance (DeFi) data including DeFi market cap, trading volume
    /// </remarks>
    public Task<GlobalDeFi> GlobalDefi(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/global/decentralized_finance_defi"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GlobalDeFi>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// New Pools List
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>, <c>network</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the latest pools across all networks on GeckoTerminal
    /// </remarks>
    public Task<Pool> LatestPoolsList(string? include,
        int? page,
        bool? includeGtCommunityData,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/new_pools"),
            [],
            [new Param("include", include),
                new Param("page", page),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// New Pools by Network
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the latest pools based on the provided network
    /// </remarks>
    public Task<Pool> LatestPoolsNetwork(string? include,
        int? page,
        bool? includeGtCommunityData,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/new_pools"),
            [new TemplateParam("network", network)],
            [new Param("include", include),
                new Param("page", page),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Networks List
    /// </summary>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworksList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To retrieve a list of all supported networks on GeckoTerminal
    /// </remarks>
    public Task<NetworksList> NetworksList(int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks"),
            [],
            [new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NetworksList>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// NFTs Collection Data by Contract Address
    /// </summary>
    /// <param name="assetPlatformId">Asset platform ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.</param>
    /// <param name="contractAddress">Contract address of the NFT collection.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Nftdata"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the NFT data (name, floor price, 24hr volume, ...) based on the NFT collection contract address and respective asset platform
    /// </remarks>
    public Task<Nftdata> NftsContractAddress(string assetPlatformId = "ethereum",
        string contractAddress = "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/nfts/{asset_platform_id}/contract/{contract_address}"),
            [new TemplateParam("asset_platform_id", assetPlatformId),
                new TemplateParam("contract_address", contractAddress)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Nftdata>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// NFTs Collection Data by ID
    /// </summary>
    /// <param name="id">NFT collection ID.  *refers to <see href="/reference/nfts-list"><c>/nfts/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Nftdata"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the NFT data (name, floor price, 24hr volume, ...) based on the NFT collection ID
    /// </remarks>
    public Task<Nftdata> NftsId(string id = "pudgy-penguins",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/nfts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Nftdata>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// NFTs List
    /// </summary>
    /// <param name="order">Sort order of responses.</param>
    /// <param name="perPage">Total results per page.  Valid values: 1...250</param>
    /// <param name="page">Page through results.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="NftsList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all supported NFTs with ID, contract address, name, asset platform ID and symbol on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<NftsList>> NftsList(Order7? order,
        int? perPage,
        int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/nfts/list"),
            [],
            [new Param("order", order), new Param("per_page", perPage), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<NftsList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Price by Token Addresses
    /// </summary>
    /// <param name="includeMarketCap">Include market capitalization.  Default: <c>false</c></param>
    /// <param name="mcapFdvFallback">Return FDV if market cap is not available.  Default: <c>false</c></param>
    /// <param name="include24HrVol">Include 24hr volume.  Default: <c>false</c></param>
    /// <param name="include24HrPriceChange">Include 24hr price change.  Default: <c>false</c></param>
    /// <param name="includeTotalReserveInUsd">Include total reserve in USD.  Default: <c>false</c></param>
    /// <param name="includeInactiveSource">Include token price data from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="addresses">Token contract address, comma-separated if more than one token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnchainSimplePrice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get token price based on the provided token contract address on a network
    /// </remarks>
    public Task<OnchainSimplePrice> OnchainSimplePrice(bool? includeMarketCap,
        bool? mcapFdvFallback,
        bool? include24HrVol,
        bool? include24HrPriceChange,
        bool? includeTotalReserveInUsd,
        bool? includeInactiveSource,
        string network = "eth",
        string addresses = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/simple/networks/{network}/token_price/{addresses}"),
            [new TemplateParam("network", network), new TemplateParam("addresses", addresses)],
            [new Param("include_market_cap", includeMarketCap),
                new Param("mcap_fdv_fallback", mcapFdvFallback),
                new Param("include_24hr_vol", include24HrVol),
                new Param("include_24hr_price_change", include24HrPriceChange),
                new Param("include_total_reserve_in_usd", includeTotalReserveInUsd),
                new Param("include_inactive_source", includeInactiveSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnchainSimplePrice>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// API Server Status
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PingServer"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To check the API server status
    /// </remarks>
    public Task<PingServer> PingServer(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/ping"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PingServer>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Specific Pool Data by Pool Address
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="includeVolumeBreakdown">Include volume breakdown.  Default: <c>false</c></param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="address">Pool address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolAddressData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the specific pool based on the provided network and pool address
    /// </remarks>
    public Task<PoolAddressData> PoolAddress(string? include,
        bool? includeVolumeBreakdown,
        bool? includeComposition,
        string network = "eth",
        string address = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{address}"),
            [new TemplateParam("network", network), new TemplateParam("address", address)],
            [new Param("include", include),
                new Param("include_volume_breakdown", includeVolumeBreakdown),
                new Param("include_composition", includeComposition)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolAddressData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Pool OHLCV Chart by Pool Address
    /// </summary>
    /// <param name="timeframe">Timeframe of the OHLCV chart.</param>
    /// <param name="aggregate">Time period to aggregate each OHLCV.  Available values (day): <c>1</c>  Available values (hour): <c>1</c>, <c>4</c>, <c>12</c>  Available values (minute): <c>1</c>, <c>5</c>, <c>15</c>  Default value: 1</param>
    /// <param name="beforeTimestamp">Return OHLCV data before this timestamp (integer seconds since epoch).</param>
    /// <param name="limit">Number of OHLCV results to return, maximum 1000.  Default value: 100</param>
    /// <param name="currency">Return OHLCV in USD or quote token.  Default: <c>usd</c></param>
    /// <param name="token">Return OHLCV for token, use this to invert the chart.  Available values: <c>base</c>, <c>quote</c>, or token address.  Default: <c>base</c></param>
    /// <param name="includeEmptyIntervals">Include empty intervals with no trade data.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="poolAddress">Pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Ohlcv"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the OHLCV chart (Open, High, Low, Close, Volume) of a pool based on the provided pool address on a network
    /// </remarks>
    public Task<Ohlcv> PoolOhlcvContractAddress(Timeframe timeframe,
        string? aggregate,
        int? beforeTimestamp,
        int? limit,
        Currency? currency,
        string? token,
        bool? includeEmptyIntervals,
        string network = "eth",
        string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{pool_address}/ohlcv/{timeframe}"),
            [new TemplateParam("network", network),
                new TemplateParam("pool_address", poolAddress),
                new TemplateParam("timeframe", timeframe)],
            [new Param("aggregate", aggregate),
                new Param("before_timestamp", beforeTimestamp),
                new Param("limit", limit),
                new Param("currency", currency),
                new Param("token", token),
                new Param("include_empty_intervals", includeEmptyIntervals)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Ohlcv>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Pool Tokens Info by Pool Address
    /// </summary>
    /// <param name="include">Attributes to include.</param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="poolAddress">Pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolTokensInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query pool metadata (base and quote token details, image, socials, websites, description, contract address, etc.) based on a provided pool contract address on a network
    /// </remarks>
    public Task<PoolTokensInfo> PoolTokenInfoContractAddress(Include2? include,
        string network = "solana",
        string poolAddress = "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{pool_address}/info"),
            [new TemplateParam("network", network), new TemplateParam("pool_address", poolAddress)],
            [new Param("include", include)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolTokensInfo>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Past 24 Hour Trades by Pool Address
    /// </summary>
    /// <param name="tradeVolumeInUsdGreaterThan">Filter trades by trade volume in USD greater than this value.  Default value: 0</param>
    /// <param name="token">Return trades for token, use this to invert the chart.  Available values: <c>base</c>, <c>quote</c>, or token address.  Default: <c>base</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="poolAddress">Pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Trades"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the last 300 trades in the past 24 hours based on the provided pool address
    /// </remarks>
    public Task<Trades> PoolTradesContractAddress(double? tradeVolumeInUsdGreaterThan,
        string? token,
        string network = "eth",
        string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{pool_address}/trades"),
            [new TemplateParam("network", network), new TemplateParam("pool_address", poolAddress)],
            [new Param("trade_volume_in_usd_greater_than", tradeVolumeInUsdGreaterThan), new Param("token", token)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Trades>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Multiple Pools Data by Pool Addresses
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="includeVolumeBreakdown">Include volume breakdown.  Default: <c>false</c></param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="addresses">Pool contract address, comma-separated if more than one pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MultiPoolAddressData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query multiple pools based on the provided network and pool addresses
    /// </remarks>
    public Task<MultiPoolAddressData> PoolsAddresses(string? include,
        bool? includeVolumeBreakdown,
        bool? includeComposition,
        string network = "eth",
        string addresses = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/multi/{addresses}"),
            [new TemplateParam("network", network), new TemplateParam("addresses", addresses)],
            [new Param("include", include),
                new Param("include_volume_breakdown", includeVolumeBreakdown),
                new Param("include_composition", includeComposition)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MultiPoolAddressData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Treasury Holdings by Entity ID
    /// </summary>
    /// <param name="holdingAmountChange">Include holding amount change for specified timeframes, comma-separated if querying more than 1 timeframe.  Valid values: <c>7d</c>, <c>14d</c>, <c>30d</c>, <c>90d</c>, <c>1y</c>, <c>ytd</c></param>
    /// <param name="holdingChangePercentage">Include holding change percentage for specified timeframes, comma-separated if querying more than 1 timeframe.  Valid values: <c>7d</c>, <c>14d</c>, <c>30d</c>, <c>90d</c>, <c>1y</c>, <c>ytd</c></param>
    /// <param name="entityId">Public company or government entity ID.  *refers to <see href="/reference/entities-list"><c>/entities/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasuryEntity"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query public companies' and governments' cryptocurrency holdings by entity ID
    /// </remarks>
    public Task<PublicTreasuryEntity> PublicTreasuryEntity(string? holdingAmountChange,
        string? holdingChangePercentage,
        string entityId = "strategy",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/public_treasury/{entity_id}"),
            [new TemplateParam("entity_id", entityId)],
            [new Param("holding_amount_change", holdingAmountChange),
                new Param("holding_change_percentage", holdingChangePercentage)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasuryEntity>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Treasury Holdings Historical Chart Data by ID
    /// </summary>
    /// <param name="includeEmptyIntervals">Include empty intervals with no transaction data.  Default: <c>false</c></param>
    /// <param name="entityId">Public company or government entity ID.  *refers to <see href="/reference/entities-list"><c>/entities/list</c></see>.</param>
    /// <param name="coinId">Coin ID.  e.g. <c>bitcoin</c>, <c>ethereum</c>, <c>solana</c>, <c>binancecoin</c></param>
    /// <param name="days">Data up to number of days ago.  Valid values: <c>7</c>, <c>14</c>, <c>30</c>, <c>90</c>, <c>180</c>, <c>365</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasuryEntityChart"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query historical cryptocurrency holdings chart of public companies and governments by entity ID and coin ID
    /// </remarks>
    public Task<PublicTreasuryEntityChart> PublicTreasuryEntityChart(bool? includeEmptyIntervals,
        string entityId = "strategy",
        string coinId = "bitcoin",
        string days = "365",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/public_treasury/{entity_id}/{coin_id}/holding_chart"),
            [new TemplateParam("entity_id", entityId), new TemplateParam("coin_id", coinId)],
            [new Param("days", days), new Param("include_empty_intervals", includeEmptyIntervals)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasuryEntityChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Crypto Treasury Transaction History by Entity ID
    /// </summary>
    /// <param name="perPage">Total results per page.  Default value: 100  Valid values: 1...250</param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="order">Sort order of transactions.  Default: <c>date_desc</c></param>
    /// <param name="coinIds">Filter transactions by coin IDs, comma-separated if querying more than 1 coin.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see>.</param>
    /// <param name="entityId">Public company or government entity ID.  *refers to <see href="/reference/entities-list"><c>/entities/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasuryTransactionHistory"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query public companies' and governments' cryptocurrency transaction history by entity ID
    /// </remarks>
    public Task<PublicTreasuryTransactionHistory> PublicTreasuryTransactionHistory(int? perPage,
        int? page,
        Order6? order,
        string? coinIds,
        string entityId = "strategy",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/public_treasury/{entity_id}/transaction_history"),
            [new TemplateParam("entity_id", entityId)],
            [new Param("per_page", perPage),
                new Param("page", page),
                new Param("order", order),
                new Param("coin_ids", coinIds)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasuryTransactionHistory>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Search Queries
    /// </summary>
    /// <param name="query">Search query</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Search"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To search for coins, categories and markets listed on CoinGecko
    /// </remarks>
    public Task<Search> SearchData(string query,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/search"),
            [],
            [new Param("query", query)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Search>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Search Pools &amp; Tokens
    /// </summary>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="query">Search query: pool contract address, token name, token symbol, or token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolSearch"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To search for pools across all networks by pool address, token name, token symbol, or token contract address
    /// </remarks>
    public Task<PoolSearch> SearchPools(string? network,
        string? include,
        int? page,
        string? query = "weth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/search/pools"),
            [],
            [new Param("query", query),
                new Param("network", network),
                new Param("include", include),
                new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolSearch>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Price by IDs, Symbols, or Names
    /// </summary>
    /// <param name="includeTokens">For <c>symbols</c> lookups, specify <c>all</c> to include all matching tokens.  Default <c>top</c> returns top-ranked tokens by market cap or volume.</param>
    /// <param name="includeMarketCap">Include market capitalization.  Default: false</param>
    /// <param name="include24HrVol">Include 24-hour trading volume.  Default: false</param>
    /// <param name="include24HrChange">Include 24-hour change percentage.  Default: false</param>
    /// <param name="includeLastUpdatedAt">Include last updated price time as a UNIX timestamp.  Default: false</param>
    /// <param name="precision">Decimal places for currency price value</param>
    /// <param name="vsCurrencies">Target currency of coins, comma-separated if querying more than 1 currency.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see></param>
    /// <param name="ids">Coins' IDs, comma-separated if querying more than 1 coin.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see></param>
    /// <param name="names">Coins' names, comma-separated if querying more than 1 coin.</param>
    /// <param name="symbols">Coins' symbols, comma-separated if querying more than 1 coin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="SimplePrice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the prices of one or more coins by using their unique Coin API IDs, symbols, or names
    /// </remarks>
    public Task<IReadOnlyDictionary<string, SimplePrice>> SimplePrice(IncludeTokens? includeTokens,
        bool? includeMarketCap,
        bool? include24HrVol,
        bool? include24HrChange,
        bool? includeLastUpdatedAt,
        Precision? precision,
        string vsCurrencies = "usd",
        string? ids = "bitcoin",
        string? names = "Bitcoin",
        string? symbols = "btc",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/simple/price"),
            [],
            [new Param("vs_currencies", vsCurrencies),
                new Param("ids", ids),
                new Param("names", names),
                new Param("symbols", symbols),
                new Param("include_tokens", includeTokens),
                new Param("include_market_cap", includeMarketCap),
                new Param("include_24hr_vol", include24HrVol),
                new Param("include_24hr_change", include24HrChange),
                new Param("include_last_updated_at", includeLastUpdatedAt),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, SimplePrice>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Currencies List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported currencies on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<string>> SimpleSupportedCurrencies(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/simple/supported_vs_currencies"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<string>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Price by Token Addresses
    /// </summary>
    /// <param name="includeMarketCap">Include market capitalization.  Default: false</param>
    /// <param name="include24HrVol">Include 24-hour trading volume.  Default: false</param>
    /// <param name="include24HrChange">Include 24-hour change percentage.  Default: false</param>
    /// <param name="includeLastUpdatedAt">Include last updated price time as a UNIX timestamp.  Default: false</param>
    /// <param name="precision">Decimal places for currency price value</param>
    /// <param name="id">Asset platform's ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see></param>
    /// <param name="contractAddresses">Token contract addresses, comma-separated if querying more than 1 token</param>
    /// <param name="vsCurrencies">Target currency of coins, comma-separated if querying more than 1 currency.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="SimplePrice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query one or more token prices by using their token contract addresses
    /// </remarks>
    public Task<IReadOnlyDictionary<string, SimplePrice>> SimpleTokenPrice(bool? includeMarketCap,
        bool? include24HrVol,
        bool? include24HrChange,
        bool? includeLastUpdatedAt,
        Precision? precision,
        string id = "ethereum",
        string contractAddresses = "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599",
        string vsCurrencies = "usd",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/simple/token_price/{id}"),
            [new TemplateParam("id", id)],
            [new Param("contract_addresses", contractAddresses),
                new Param("vs_currencies", vsCurrencies),
                new Param("include_market_cap", includeMarketCap),
                new Param("include_24hr_vol", include24HrVol),
                new Param("include_24hr_change", include24HrChange),
                new Param("include_last_updated_at", includeLastUpdatedAt),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, SimplePrice>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Data by Token Address
    /// </summary>
    /// <param name="include">Attributes to include.</param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="includeInactiveSource">Include token data from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="address">Token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query specific token data based on the provided token contract address on a network
    /// </remarks>
    public Task<TokenData> TokenDataContractAddress(Include? include,
        bool? includeComposition,
        bool? includeInactiveSource,
        string network = "eth",
        string address = "0xdac17f958d2ee523a2206206994597c13d831ec7",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/{address}"),
            [new TemplateParam("network", network), new TemplateParam("address", address)],
            [new Param("include", include),
                new Param("include_composition", includeComposition),
                new Param("include_inactive_source", includeInactiveSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Info by Token Address
    /// </summary>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="address">Token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query token metadata (name, symbol, CoinGecko ID, image, socials, websites, description, etc.) based on a provided token contract address on a network
    /// </remarks>
    public Task<TokenInfo> TokenInfoContractAddress(string network = "solana",
        string address = "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/{address}/info"),
            [new TemplateParam("network", network), new TemplateParam("address", address)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenInfo>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Lists by Asset Platform ID
    /// </summary>
    /// <param name="assetPlatformId">Asset platform ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenLists"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get full list of tokens of a blockchain network (asset platform) that is supported by <see href="https://tokenlists.org/">Ethereum token list standard</see>
    /// </remarks>
    public Task<TokenLists> TokenLists(string assetPlatformId = "ethereum",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/token_lists/{asset_platform_id}/all.json"),
            [new TemplateParam("asset_platform_id", assetPlatformId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenLists>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Tokens Data by Token Addresses
    /// </summary>
    /// <param name="include">Attributes to include.</param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="includeInactiveSource">Include tokens from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="addresses">Token contract address, comma-separated if more than one token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MultiTokenData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query multiple tokens data based on the provided token contract addresses on a network
    /// </remarks>
    public Task<MultiTokenData> TokensDataContractAddresses(Include? include,
        bool? includeComposition,
        bool? includeInactiveSource,
        string network = "solana",
        string addresses = "6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/multi/{addresses}"),
            [new TemplateParam("network", network), new TemplateParam("addresses", addresses)],
            [new Param("include", include),
                new Param("include_composition", includeComposition),
                new Param("include_inactive_source", includeInactiveSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MultiTokenData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Most Recently Updated Tokens List
    /// </summary>
    /// <param name="include">Attributes for related resources to include.</param>
    /// <param name="network">Filter tokens by provided network.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenInfoRecentlyUpdated"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query 100 most recently updated tokens info of a specific network or across all networks on GeckoTerminal
    /// </remarks>
    public Task<TokenInfoRecentlyUpdated> TokensInfoRecentUpdated(Include3? include,
        string? network,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/tokens/info_recently_updated"),
            [],
            [new Param("include", include), new Param("network", network)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenInfoRecentlyUpdated>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Top Pools by Token Address
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="includeInactiveSource">Include tokens from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="sort">Sort the pools by field.  Default: <c>h24_volume_usd_liquidity_desc</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="tokenAddress">Token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query top pools based on the provided token contract address on a network
    /// </remarks>
    public Task<Pool> TopPoolsContractAddress(string? include,
        bool? includeInactiveSource,
        int? page,
        Sort2? sort,
        bool? includeGtCommunityData,
        string network = "eth",
        string tokenAddress = "0xdac17f958d2ee523a2206206994597c13d831ec7",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/{token_address}/pools"),
            [new TemplateParam("network", network), new TemplateParam("token_address", tokenAddress)],
            [new Param("include", include),
                new Param("include_inactive_source", includeInactiveSource),
                new Param("page", page),
                new Param("sort", sort),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Top Pools by DEX
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="sort">Sort the pools by field.  Default: <c>h24_tx_count_desc</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="dex">DEX ID.  *refers to <see href="/reference/dexes-list"><c>/onchain/networks/{network}/dexes</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the top pools based on the provided network and decentralized exchange (DEX)
    /// </remarks>
    public Task<Pool> TopPoolsDex(string? include,
        int? page,
        Sort? sort,
        bool? includeGtCommunityData,
        string network = "eth",
        string dex = "sushiswap",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/dexes/{dex}/pools"),
            [new TemplateParam("network", network), new TemplateParam("dex", dex)],
            [new Param("include", include),
                new Param("page", page),
                new Param("sort", sort),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Top Pools by Network
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="sort">Sort the pools by field.  Default: <c>h24_tx_count_desc</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the top pools based on the provided network
    /// </remarks>
    public Task<Pool> TopPoolsNetwork(string? include,
        int? page,
        Sort? sort,
        bool? includeGtCommunityData,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools"),
            [new TemplateParam("network", network)],
            [new Param("include", include),
                new Param("page", page),
                new Param("sort", sort),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Trending Pools List
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>, <c>network</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="duration">Duration to sort trending list by.  Default: <c>24h</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the trending pools across all networks on GeckoTerminal
    /// </remarks>
    public Task<Pool> TrendingPoolsList(string? include,
        int? page,
        Duration? duration,
        bool? includeGtCommunityData,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/trending_pools"),
            [],
            [new Param("include", include),
                new Param("page", page),
                new Param("duration", duration),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Trending Pools by Network
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="duration">Duration to sort trending list by.  Default: <c>24h</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the trending pools based on the provided network
    /// </remarks>
    public Task<Pool> TrendingPoolsNetwork(string? include,
        int? page,
        Duration? duration,
        bool? includeGtCommunityData,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/trending_pools"),
            [new TemplateParam("network", network)],
            [new Param("include", include),
                new Param("page", page),
                new Param("duration", duration),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Trending Search List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TrendingSearch"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query trending search coins, NFTs and categories on CoinGecko in the last 24 hours
    /// </remarks>
    public Task<TrendingSearch> TrendingSearch(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/search/trending"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TrendingSearch>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);
}
