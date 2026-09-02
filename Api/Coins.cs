using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoinGecko.Core;
using CoinGecko.Core.Authentication;
using CoinGecko.Core.ErrorResponse;
using CoinGecko.Core.Exceptions;
using CoinGecko.Core.Models;
using CoinGecko.Core.Request;
using CoinGecko.Core.Response;
using CoinGecko.Models;
using CoinGecko.Models.Enums;

namespace CoinGecko.Api;

/// <summary>
/// Coin lists, market data, details, history, charts and OHLC
/// </summary>
public sealed class Coins
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Coins(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
