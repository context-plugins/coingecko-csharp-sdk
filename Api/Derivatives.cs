using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoinGeckoDemoApi.Core;
using CoinGeckoDemoApi.Core.Authentication;
using CoinGeckoDemoApi.Core.ErrorResponse;
using CoinGeckoDemoApi.Core.Exceptions;
using CoinGeckoDemoApi.Core.Models;
using CoinGeckoDemoApi.Core.Request;
using CoinGeckoDemoApi.Core.Response;
using CoinGeckoDemoApi.Models;
using CoinGeckoDemoApi.Models.Enums;

namespace CoinGeckoDemoApi.Api;

/// <summary>
/// Derivatives exchanges and tickers
/// </summary>
public sealed class Derivatives
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Derivatives(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
