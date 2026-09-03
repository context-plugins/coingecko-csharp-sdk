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
    /// <param name="includeTokens">For <c>symbols</c> lookups, specify <c>all</c> to include all matching tokens.  Default <c>top</c> returns top-ranked tokens by market cap or volume.</param>
    /// <param name="includeMarketCap">Include market capitalization.  Default: false</param>
    /// <param name="include24HrVol">Include 24-hour trading volume.  Default: false</param>
    /// <param name="include24HrChange">Include 24-hour change percentage.  Default: false</param>
    /// <param name="includeLastUpdatedAt">Include last updated price time as a UNIX timestamp.  Default: false</param>
    /// <param name="precision">Decimal places for currency price value</param>
    /// <param name="vsCurrencies">Target currency of coins, comma-separated if querying more than 1 currency.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see></param>
    /// <param name="ids">Coins' IDs, comma-separated if querying more than 1 coin.  *refers to <see href="/reference/coins-list"><c>/coins/list</c></see></param>
    /// <param name="names">Coins' names, comma-separated if querying more than 1 coin.</param>
    /// <param name="symbols">Coins' symbols, comma-separated if querying more than 1 coin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="SimplePrice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the prices of one or more coins by using their unique Coin API IDs, symbols, or names
    /// </remarks>
    public Task<IReadOnlyDictionary<string, SimplePrice>> SimplePrice(IncludeTokens? includeTokens,
        bool? includeMarketCap,
        bool? include24HrVol,
        bool? include24HrChange,
        bool? includeLastUpdatedAt,
        Precision? precision,
        string vsCurrencies = "usd",
        string? ids = "bitcoin",
        string? names = "Bitcoin",
        string? symbols = "btc",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/simple/price"),
            [],
            [new Param("vs_currencies", vsCurrencies),
                new Param("ids", ids),
                new Param("names", names),
                new Param("symbols", symbols),
                new Param("include_tokens", includeTokens),
                new Param("include_market_cap", includeMarketCap),
                new Param("include_24hr_vol", include24HrVol),
                new Param("include_24hr_change", include24HrChange),
                new Param("include_last_updated_at", includeLastUpdatedAt),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, SimplePrice>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Currencies List
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="string"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported currencies on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<string>> SimpleSupportedCurrencies(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/simple/supported_vs_currencies"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<string>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Coin Price by Token Addresses
    /// </summary>
    /// <param name="includeMarketCap">Include market capitalization.  Default: false</param>
    /// <param name="include24HrVol">Include 24-hour trading volume.  Default: false</param>
    /// <param name="include24HrChange">Include 24-hour change percentage.  Default: false</param>
    /// <param name="includeLastUpdatedAt">Include last updated price time as a UNIX timestamp.  Default: false</param>
    /// <param name="precision">Decimal places for currency price value</param>
    /// <param name="id">Asset platform's ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see></param>
    /// <param name="contractAddresses">Token contract addresses, comma-separated if querying more than 1 token</param>
    /// <param name="vsCurrencies">Target currency of coins, comma-separated if querying more than 1 currency.  *refers to <see href="/reference/simple-supported-currencies"><c>/simple/supported_vs_currencies</c></see></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="SimplePrice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query one or more token prices by using their token contract addresses
    /// </remarks>
    public Task<IReadOnlyDictionary<string, SimplePrice>> SimpleTokenPrice(bool? includeMarketCap,
        bool? include24HrVol,
        bool? include24HrChange,
        bool? includeLastUpdatedAt,
        Precision? precision,
        string id = "ethereum",
        string contractAddresses = "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599",
        string vsCurrencies = "usd",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/simple/token_price/{id}"),
            [new TemplateParam("id", id)],
            [new Param("contract_addresses", contractAddresses),
                new Param("vs_currencies", vsCurrencies),
                new Param("include_market_cap", includeMarketCap),
                new Param("include_24hr_vol", include24HrVol),
                new Param("include_24hr_change", include24HrChange),
                new Param("include_last_updated_at", includeLastUpdatedAt),
                new Param("precision", precision)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, SimplePrice>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);
}
