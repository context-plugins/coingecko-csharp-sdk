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
}
