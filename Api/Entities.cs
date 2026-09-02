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
/// Entity directory and per-entity holdings
/// </summary>
public sealed class Entities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Entities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
