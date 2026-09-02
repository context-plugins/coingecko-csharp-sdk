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
using CoinGecko.Models.Enums;

namespace CoinGecko.Api;

/// <summary>
/// NFT collection lists and details
/// </summary>
public sealed class Nfts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Nfts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// NFTs Collection Data by Contract Address
    /// </summary>
    /// <param name="assetPlatformId">Asset platform ID.  *refers to <see href="/reference/asset-platforms-list"><c>/asset_platforms</c></see>.</param>
    /// <param name="contractAddress">Contract address of the NFT collection.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NftData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the NFT data (name, floor price, 24hr volume, ...) based on the NFT collection contract address and respective asset platform
    /// </remarks>
    public Task<NftData> NftsContractAddress(string assetPlatformId = "ethereum",
        string contractAddress = "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/nfts/{asset_platform_id}/contract/{contract_address}"),
            [new TemplateParam("asset_platform_id", assetPlatformId),
                new TemplateParam("contract_address", contractAddress)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NftData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// NFTs Collection Data by ID
    /// </summary>
    /// <param name="id">NFT collection ID.  *refers to <see href="/reference/nfts-list"><c>/nfts/list</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NftData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the NFT data (name, floor price, 24hr volume, ...) based on the NFT collection ID
    /// </remarks>
    public Task<NftData> NftsId(string id = "pudgy-penguins",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/nfts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NftData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// NFTs List
    /// </summary>
    /// <param name="order">Sort order of responses.</param>
    /// <param name="perPage">Total results per page.  Valid values: 1...250</param>
    /// <param name="page">Page through results.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="NfTsList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all supported NFTs with ID, contract address, name, asset platform ID and symbol on CoinGecko
    /// </remarks>
    public Task<IReadOnlyList<NfTsList>> NftsList(Order7? order,
        int? perPage,
        int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/nfts/list"),
            [],
            [new Param("order", order), new Param("per_page", perPage), new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<NfTsList>>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);
}
