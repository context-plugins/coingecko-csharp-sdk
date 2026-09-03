using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoinGeckoDemoApi.Core;
using CoinGeckoDemoApi.Core.Authentication;
using CoinGeckoDemoApi.Core.ErrorResponse;
using CoinGeckoDemoApi.Core.Exceptions;
using CoinGeckoDemoApi.Core.Request;
using CoinGeckoDemoApi.Core.Response;
using CoinGeckoDemoApi.Models;

namespace CoinGeckoDemoApi.Api;

/// <summary>
/// Global crypto market data and DeFi stats
/// </summary>
public sealed class GlobalApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal GlobalApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

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
}
