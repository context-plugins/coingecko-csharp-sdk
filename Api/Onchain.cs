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
using CoinGecko.Requests.Onchain;

namespace CoinGecko.Api;

/// <summary>
/// On-chain DEX data (GeckoTerminal): networks, pools, tokens and OHLCV
/// </summary>
public sealed class Onchain
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Onchain(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// DEXs List by Network
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DexesList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported decentralized exchanges (DEXs) based on the provided network on GeckoTerminal
    /// </remarks>
    public Task<DexesList> DexesList(DexesListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/dexes"),
            [new TemplateParam("network", request.Network)],
            [new Param("page", request.Page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DexesList>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Pools List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the latest pools across all networks on GeckoTerminal
    /// </remarks>
    public Task<Pool> LatestPoolsList(LatestPoolsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/new_pools"),
            [],
            [
                new Param("include", request.Include),
                new Param("page", request.Page),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// New Pools by Network
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the latest pools based on the provided network
    /// </remarks>
    public Task<Pool> LatestPoolsNetwork(LatestPoolsNetworkRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/new_pools"),
            [new TemplateParam("network", request.Network)],
            [
                new Param("include", request.Include),
                new Param("page", request.Page),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Networks List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworksList"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To retrieve a list of all supported networks on GeckoTerminal
    /// </remarks>
    public Task<NetworksList> NetworksList(NetworksListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks"),
            [],
            [new Param("page", request.Page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NetworksList>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Token Price by Token Addresses
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnchainSimplePrice"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get token price based on the provided token contract address on a network
    /// </remarks>
    public Task<OnchainSimplePrice> OnchainSimplePrice(OnchainSimplePriceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/simple/networks/{network}/token_price/{addresses}"),
            [new TemplateParam("network", request.Network), new TemplateParam("addresses", request.Addresses)],
            [
                new Param("include_market_cap", request.IncludeMarketCap),
                new Param("mcap_fdv_fallback", request.McapFdvFallback),
                new Param("include_24hr_vol", request.Include24HrVol),
                new Param("include_24hr_price_change", request.Include24HrPriceChange),
                new Param("include_total_reserve_in_usd", request.IncludeTotalReserveInUsd),
                new Param("include_inactive_source", request.IncludeInactiveSource),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnchainSimplePrice>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Specific Pool Data by Pool Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolAddressData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the specific pool based on the provided network and pool address
    /// </remarks>
    public Task<PoolAddressData> PoolAddress(PoolAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/pools/{address}"),
            [new TemplateParam("network", request.Network), new TemplateParam("address", request.Address)],
            [
                new Param("include", request.Include),
                new Param("include_volume_breakdown", request.IncludeVolumeBreakdown),
                new Param("include_composition", request.IncludeComposition),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolAddressData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Pool OHLCV Chart by Pool Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Ohlcv"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the OHLCV chart (Open, High, Low, Close, Volume) of a pool based on the provided pool address on a network
    /// </remarks>
    public Task<Ohlcv> PoolOhlcvContractAddress(PoolOhlcvContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/pools/{pool_address}/ohlcv/{timeframe}"),
            [
                new TemplateParam("network", request.Network),
                new TemplateParam("pool_address", request.PoolAddress),
                new TemplateParam("timeframe", request.Timeframe),
            ],
            [
                new Param("aggregate", request.Aggregate),
                new Param("before_timestamp", request.BeforeTimestamp),
                new Param("limit", request.Limit),
                new Param("currency", request.Currency),
                new Param("token", request.Token),
                new Param("include_empty_intervals", request.IncludeEmptyIntervals),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Ohlcv>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Pool Tokens Info by Pool Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolTokensInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query pool metadata (base and quote token details, image, socials, websites, description, contract address, etc.) based on a provided pool contract address on a network
    /// </remarks>
    public Task<PoolTokensInfo> PoolTokenInfoContractAddress(PoolTokenInfoContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/pools/{pool_address}/info"),
            [new TemplateParam("network", request.Network), new TemplateParam("pool_address", request.PoolAddress)],
            [new Param("include", request.Include)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolTokensInfo>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Past 24 Hour Trades by Pool Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Trades"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the last 300 trades in the past 24 hours based on the provided pool address
    /// </remarks>
    public Task<Trades> PoolTradesContractAddress(PoolTradesContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/pools/{pool_address}/trades"),
            [new TemplateParam("network", request.Network), new TemplateParam("pool_address", request.PoolAddress)],
            [
                new Param("trade_volume_in_usd_greater_than", request.TradeVolumeInUsdGreaterThan),
                new Param("token", request.Token),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Trades>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Multiple Pools Data by Pool Addresses
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MultiPoolAddressData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query multiple pools based on the provided network and pool addresses
    /// </remarks>
    public Task<MultiPoolAddressData> PoolsAddresses(PoolsAddressesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/pools/multi/{addresses}"),
            [new TemplateParam("network", request.Network), new TemplateParam("addresses", request.Addresses)],
            [
                new Param("include", request.Include),
                new Param("include_volume_breakdown", request.IncludeVolumeBreakdown),
                new Param("include_composition", request.IncludeComposition),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MultiPoolAddressData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Search Pools &amp; Tokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolSearch"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To search for pools across all networks by pool address, token name, token symbol, or token contract address
    /// </remarks>
    public Task<PoolSearch> SearchPools(SearchPoolsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/search/pools"),
            [],
            [
                new Param("query", request.Query),
                new Param("network", request.Network),
                new Param("include", request.Include),
                new Param("page", request.Page),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolSearch>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Token Data by Token Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query specific token data based on the provided token contract address on a network
    /// </remarks>
    public Task<TokenData> TokenDataContractAddress(TokenDataContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/tokens/{address}"),
            [new TemplateParam("network", request.Network), new TemplateParam("address", request.Address)],
            [
                new Param("include", request.Include),
                new Param("include_composition", request.IncludeComposition),
                new Param("include_inactive_source", request.IncludeInactiveSource),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Token Info by Token Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query token metadata (name, symbol, CoinGecko ID, image, socials, websites, description, etc.) based on a provided token contract address on a network
    /// </remarks>
    public Task<TokenInfo> TokenInfoContractAddress(TokenInfoContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/tokens/{address}/info"),
            [new TemplateParam("network", request.Network), new TemplateParam("address", request.Address)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenInfo>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Tokens Data by Token Addresses
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MultiTokenData"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query multiple tokens data based on the provided token contract addresses on a network
    /// </remarks>
    public Task<MultiTokenData> TokensDataContractAddresses(TokensDataContractAddressesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/tokens/multi/{addresses}"),
            [new TemplateParam("network", request.Network), new TemplateParam("addresses", request.Addresses)],
            [
                new Param("include", request.Include),
                new Param("include_composition", request.IncludeComposition),
                new Param("include_inactive_source", request.IncludeInactiveSource),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MultiTokenData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Most Recently Updated Tokens List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenInfoRecentlyUpdated"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query 100 most recently updated tokens info of a specific network or across all networks on GeckoTerminal
    /// </remarks>
    public Task<TokenInfoRecentlyUpdated> TokensInfoRecentUpdated(TokensInfoRecentUpdatedRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/tokens/info_recently_updated"),
            [],
            [new Param("include", request.Include), new Param("network", request.Network)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenInfoRecentlyUpdated>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Top Pools by Token Address
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query top pools based on the provided token contract address on a network
    /// </remarks>
    public Task<Pool> TopPoolsContractAddress(TopPoolsContractAddressRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/tokens/{token_address}/pools"),
            [new TemplateParam("network", request.Network), new TemplateParam("token_address", request.TokenAddress)],
            [
                new Param("include", request.Include),
                new Param("include_inactive_source", request.IncludeInactiveSource),
                new Param("page", request.Page),
                new Param("sort", request.Sort),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Top Pools by DEX
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the top pools based on the provided network and decentralized exchange (DEX)
    /// </remarks>
    public Task<Pool> TopPoolsDex(TopPoolsDexRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/dexes/{dex}/pools"),
            [new TemplateParam("network", request.Network), new TemplateParam("dex", request.Dex)],
            [
                new Param("include", request.Include),
                new Param("page", request.Page),
                new Param("sort", request.Sort),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Top Pools by Network
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the top pools based on the provided network
    /// </remarks>
    public Task<Pool> TopPoolsNetwork(TopPoolsNetworkRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/pools"),
            [new TemplateParam("network", request.Network)],
            [
                new Param("include", request.Include),
                new Param("page", request.Page),
                new Param("sort", request.Sort),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Trending Pools List
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the trending pools across all networks on GeckoTerminal
    /// </remarks>
    public Task<Pool> TrendingPoolsList(TrendingPoolsListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/trending_pools"),
            [],
            [
                new Param("include", request.Include),
                new Param("page", request.Page),
                new Param("duration", request.Duration),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Trending Pools by Network
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the trending pools based on the provided network
    /// </remarks>
    public Task<Pool> TrendingPoolsNetwork(TrendingPoolsNetworkRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/onchain/networks/{network}/trending_pools"),
            [new TemplateParam("network", request.Network)],
            [
                new Param("include", request.Include),
                new Param("page", request.Page),
                new Param("duration", request.Duration),
                new Param("include_gt_community_data", request.IncludeGtCommunityData),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            cancellationToken);
}
