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
using CoinGecko.Requests.Simple;

namespace CoinGecko.Api;

/// <summary>
/// Simple price and supported vs-currencies
/// </summary>
public sealed class Simple
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Simple(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Coin Price by IDs, Symbols, or Names
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="SimplePrice"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the prices of one or more coins by using their unique Coin API IDs, symbols, or names
    /// </remarks>
    public Task<IReadOnlyDictionary<string, SimplePrice>> SimplePrice(SimplePriceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/simple/price"),
            [],
            [
                new Param("vs_currencies", request.VsCurrencies),
                new Param("ids", request.Ids),
                new Param("names", request.Names),
                new Param("symbols", request.Symbols),
                new Param("include_tokens", request.IncludeTokens),
                new Param("include_market_cap", request.IncludeMarketCap),
                new Param("include_24hr_vol", request.Include24HrVol),
                new Param("include_24hr_change", request.Include24HrChange),
                new Param("include_last_updated_at", request.IncludeLastUpdatedAt),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, SimplePrice>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Currencies List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported currencies on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<string>> SimpleSupportedCurrencies(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/simple/supported_vs_currencies"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<string>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Coin Price by Token Addresses
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="SimplePrice"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query one or more token prices by using their token contract addresses
    /// </remarks>
    public Task<IReadOnlyDictionary<string, SimplePrice>> SimpleTokenPrice(SimpleTokenPriceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/simple/token_price/{id}"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("contract_addresses", request.ContractAddresses),
                new Param("vs_currencies", request.VsCurrencies),
                new Param("include_market_cap", request.IncludeMarketCap),
                new Param("include_24hr_vol", request.Include24HrVol),
                new Param("include_24hr_change", request.Include24HrChange),
                new Param("include_last_updated_at", request.IncludeLastUpdatedAt),
                new Param("precision", request.Precision),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, SimplePrice>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);
}
