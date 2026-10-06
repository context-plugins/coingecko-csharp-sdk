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
using CoinGecko.Requests.Coins;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Category1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the coins categories with market data (market cap, volume, etc.) on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<Category1>> CoinsCategories(CoinsCategoriesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/categories"),
            [],
            [new Param("order", request.Order)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Category1>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coins Categories List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CategoriesList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported coins categories on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<CategoriesList>> CoinsCategoriesList(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/categories/list"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CategoriesList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Data by Token Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsContractAddress"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the metadata (image, websites, socials, description, contract address, etc.) and market data (price, ATH, exchange tickers, etc.) of a coin based on an asset platform and a particular token contract address
    /// </remarks>
    public Task<CoinsContractAddress> CoinsContractAddress(CoinsContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/contract/{contract_address}"),
            [new TemplateParam("id", request.Id), new TemplateParam("contract_address", request.ContractAddress)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsContractAddress>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Data by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsId"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the metadata (image, websites, socials, description, contract address, etc.) and market data (price, ATH, exchange tickers, etc.) of a coin based on a particular coin ID
    /// </remarks>
    public Task<CoinsId> CoinsId(CoinsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("localization", request.Localization),
                new Param("tickers", request.Tickers),
                new Param("market_data", request.MarketData),
                new Param("community_data", request.CommunityData),
                new Param("developer_data", request.DeveloperData),
                new Param("sparkline", request.Sparkline),
                new Param("include_categories_details", request.IncludeCategoriesDetails),
                new Param("dex_pair_format", request.DexPairFormat),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsId>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Historical Data by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsIdHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the historical data (price, market cap, 24hrs volume, etc.) at a given date for a coin based on a particular coin ID
    /// </remarks>
    public Task<CoinsIdHistory> CoinsIdHistory(CoinsIdHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/history"),
            [new TemplateParam("id", request.Id)],
            [new Param("date", request.Date), new Param("localization", request.Localization)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsIdHistory>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Historical Chart Data by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data of a coin including time in UNIX, price, market cap and 24hrs volume based on particular coin ID
    /// </remarks>
    public Task<CoinsMarketChart> CoinsIdMarketChart(CoinsIdMarketChartRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/market_chart"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("vs_currency", request.VsCurrency),
                new Param("days", request.Days),
                new Param("interval", request.Interval),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Historical Chart Data within Time Range by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data of a coin within certain time range in UNIX along with price, market cap and 24hrs volume based on particular coin ID
    /// </remarks>
    public Task<CoinsMarketChart> CoinsIdMarketChartRange(CoinsIdMarketChartRangeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/market_chart/range"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("vs_currency", request.VsCurrency),
                new Param("from", request.From),
                new Param("to", request.To),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin OHLC Chart by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="double"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the OHLC chart (Open, High, Low, Close) of a coin based on particular coin ID
    /// </remarks>
    public Task<IReadOnlyList<IReadOnlyList<double>>> CoinsIdOhlc(CoinsIdOhlcRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/ohlc"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("vs_currency", request.VsCurrency),
                new Param("days", request.Days),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<IReadOnlyList<double>>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Tickers by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsIdTickers"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the coin tickers on both centralized exchange (CEX) and decentralized exchange (DEX) based on a particular coin ID
    /// </remarks>
    public Task<CoinsIdTickers> CoinsIdTickers(CoinsIdTickersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/tickers"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("exchange_ids", request.ExchangeIds),
                new Param("include_exchange_logo", request.IncludeExchangeLogo),
                new Param("page", request.Page),
                new Param("order", request.Order),
                new Param("depth", request.Depth),
                new Param("dex_pair_format", request.DexPairFormat),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsIdTickers>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coins List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CoinsList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported coins on CoinGecko with coin ID, name and symbol
    /// </remarks>
    public Task<IReadOnlyList<CoinsList>> CoinsList(CoinsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/list"),
            [],
            [new Param("include_platform", request.IncludePlatform), new Param("status", request.Status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CoinsList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coins List with Market Data
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CoinsMarket"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported coins with price, market cap, volume and market related data
    /// </remarks>
    public Task<IReadOnlyList<CoinsMarket>> CoinsMarkets(CoinsMarketsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/markets"),
            [],
            [
                new Param("vs_currency", request.VsCurrency),
                new Param("ids", request.Ids),
                new Param("names", request.Names),
                new Param("symbols", request.Symbols),
                new Param("include_tokens", request.IncludeTokens),
                new Param("category", request.Category),
                new Param("order", request.Order),
                new Param("per_page", request.PerPage),
                new Param("page", request.Page),
                new Param("sparkline", request.Sparkline),
                new Param("price_change_percentage", request.PriceChangePercentage),
                new Param("locale", request.Locale),
                new Param("precision", request.Precision),
                new Param("include_rehypothecated", request.IncludeRehypothecated),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CoinsMarket>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Historical Chart Data by Token Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data including time in UNIX, price, market cap and 24hrs volume based on asset platform and particular token contract address
    /// </remarks>
    public Task<CoinsMarketChart> ContractAddressMarketChart(ContractAddressMarketChartRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/contract/{contract_address}/market_chart"),
            [new TemplateParam("id", request.Id), new TemplateParam("contract_address", request.ContractAddress)],
            [
                new Param("vs_currency", request.VsCurrency),
                new Param("days", request.Days),
                new Param("interval", request.Interval),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Historical Chart Data within Time Range by Token Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CoinsMarketChart"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the historical chart data within certain time range in UNIX along with price, market cap and 24hrs volume based on asset platform and particular token contract address
    /// </remarks>
    public Task<CoinsMarketChart> ContractAddressMarketChartRange(ContractAddressMarketChartRangeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/coins/{id}/contract/{contract_address}/market_chart/range"),
            [new TemplateParam("id", request.Id), new TemplateParam("contract_address", request.ContractAddress)],
            [
                new Param("vs_currency", request.VsCurrency),
                new Param("from", request.From),
                new Param("to", request.To),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CoinsMarketChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);
}
