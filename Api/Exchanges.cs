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
using CoinGecko.Models.AnyOf;
using CoinGecko.Models.Enums;

namespace CoinGecko.Api;

/// <summary>
/// Exchange lists, details, tickers, volume charts and BTC exchange rates
/// </summary>
public sealed class Exchanges
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Exchanges(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
    public Task<IReadOnlyList<Exchange1>> ExchangesInvoke(double? perPage,
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
}
