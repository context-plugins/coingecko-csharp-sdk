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

namespace CoinGeckoDemoApi.Api;

/// <summary>
/// Search and trending
/// </summary>
public sealed class SearchApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SearchApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
