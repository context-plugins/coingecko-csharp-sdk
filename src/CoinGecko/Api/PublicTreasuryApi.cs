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
using CoinGecko.Requests.PublicTreasuryApi;

namespace CoinGecko.Api;

/// <summary>
/// Public companies and entities holding crypto treasuries
/// </summary>
public sealed class PublicTreasuryApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PublicTreasuryApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Crypto Treasury Holdings by Entity ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasuryEntity"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query public companies' and governments' cryptocurrency holdings by entity ID
    /// </remarks>
    public Task<PublicTreasuryEntity> PublicTreasuryEntity(PublicTreasuryEntityRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/public_treasury/{entity_id}"),
            [new TemplateParam("entity_id", request.EntityId)],
            [
                new Param("holding_amount_change", request.HoldingAmountChange),
                new Param("holding_change_percentage", request.HoldingChangePercentage),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasuryEntity>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Crypto Treasury Holdings Historical Chart Data by ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasuryEntityChart"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query historical cryptocurrency holdings chart of public companies and governments by entity ID and coin ID
    /// </remarks>
    public Task<PublicTreasuryEntityChart> PublicTreasuryEntityChart(PublicTreasuryEntityChartRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/public_treasury/{entity_id}/{coin_id}/holding_chart"),
            [new TemplateParam("entity_id", request.EntityId), new TemplateParam("coin_id", request.CoinId)],
            [new Param("days", request.Days), new Param("include_empty_intervals", request.IncludeEmptyIntervals)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasuryEntityChart>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Crypto Treasury Transaction History by Entity ID
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublicTreasuryTransactionHistory"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query public companies' and governments' cryptocurrency transaction history by entity ID
    /// </remarks>
    public Task<PublicTreasuryTransactionHistory> PublicTreasuryTransactionHistory(PublicTreasuryTransactionHistoryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/public_treasury/{entity_id}/transaction_history"),
            [new TemplateParam("entity_id", request.EntityId)],
            [
                new Param("per_page", request.PerPage),
                new Param("page", request.Page),
                new Param("order", request.Order),
                new Param("coin_ids", request.CoinIds),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PublicTreasuryTransactionHistory>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);
}
