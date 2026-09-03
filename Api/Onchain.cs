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
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DexesList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the supported decentralized exchanges (DEXs) based on the provided network on GeckoTerminal
    /// </remarks>
    public Task<DexesList> DexesList(int? page,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/dexes"),
            [new TemplateParam("network", network)],
            [new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<DexesList>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// New Pools List
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>, <c>network</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the latest pools across all networks on GeckoTerminal
    /// </remarks>
    public Task<Pool> LatestPoolsList(string? include,
        int? page,
        bool? includeGtCommunityData,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/new_pools"),
            [],
            [new Param("include", include),
                new Param("page", page),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// New Pools by Network
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the latest pools based on the provided network
    /// </remarks>
    public Task<Pool> LatestPoolsNetwork(string? include,
        int? page,
        bool? includeGtCommunityData,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/new_pools"),
            [new TemplateParam("network", network)],
            [new Param("include", include),
                new Param("page", page),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Networks List
    /// </summary>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworksList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To retrieve a list of all supported networks on GeckoTerminal
    /// </remarks>
    public Task<NetworksList> NetworksList(int? page,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks"),
            [],
            [new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NetworksList>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Price by Token Addresses
    /// </summary>
    /// <param name="includeMarketCap">Include market capitalization.  Default: <c>false</c></param>
    /// <param name="mcapFdvFallback">Return FDV if market cap is not available.  Default: <c>false</c></param>
    /// <param name="include24HrVol">Include 24hr volume.  Default: <c>false</c></param>
    /// <param name="include24HrPriceChange">Include 24hr price change.  Default: <c>false</c></param>
    /// <param name="includeTotalReserveInUsd">Include total reserve in USD.  Default: <c>false</c></param>
    /// <param name="includeInactiveSource">Include token price data from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="addresses">Token contract address, comma-separated if more than one token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnchainSimplePrice"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get token price based on the provided token contract address on a network
    /// </remarks>
    public Task<OnchainSimplePrice> OnchainSimplePrice(bool? includeMarketCap,
        bool? mcapFdvFallback,
        bool? include24HrVol,
        bool? include24HrPriceChange,
        bool? includeTotalReserveInUsd,
        bool? includeInactiveSource,
        string network = "eth",
        string addresses = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/simple/networks/{network}/token_price/{addresses}"),
            [new TemplateParam("network", network), new TemplateParam("addresses", addresses)],
            [new Param("include_market_cap", includeMarketCap),
                new Param("mcap_fdv_fallback", mcapFdvFallback),
                new Param("include_24hr_vol", include24HrVol),
                new Param("include_24hr_price_change", include24HrPriceChange),
                new Param("include_total_reserve_in_usd", includeTotalReserveInUsd),
                new Param("include_inactive_source", includeInactiveSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnchainSimplePrice>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Specific Pool Data by Pool Address
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="includeVolumeBreakdown">Include volume breakdown.  Default: <c>false</c></param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="address">Pool address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolAddressData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the specific pool based on the provided network and pool address
    /// </remarks>
    public Task<PoolAddressData> PoolAddress(string? include,
        bool? includeVolumeBreakdown,
        bool? includeComposition,
        string network = "eth",
        string address = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{address}"),
            [new TemplateParam("network", network), new TemplateParam("address", address)],
            [new Param("include", include),
                new Param("include_volume_breakdown", includeVolumeBreakdown),
                new Param("include_composition", includeComposition)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolAddressData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Pool OHLCV Chart by Pool Address
    /// </summary>
    /// <param name="timeframe">Timeframe of the OHLCV chart.</param>
    /// <param name="aggregate">Time period to aggregate each OHLCV.  Available values (day): <c>1</c>  Available values (hour): <c>1</c>, <c>4</c>, <c>12</c>  Available values (minute): <c>1</c>, <c>5</c>, <c>15</c>  Default value: 1</param>
    /// <param name="beforeTimestamp">Return OHLCV data before this timestamp (integer seconds since epoch).</param>
    /// <param name="limit">Number of OHLCV results to return, maximum 1000.  Default value: 100</param>
    /// <param name="currency">Return OHLCV in USD or quote token.  Default: <c>usd</c></param>
    /// <param name="token">Return OHLCV for token, use this to invert the chart.  Available values: <c>base</c>, <c>quote</c>, or token address.  Default: <c>base</c></param>
    /// <param name="includeEmptyIntervals">Include empty intervals with no trade data.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="poolAddress">Pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Ohlcv"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To get the OHLCV chart (Open, High, Low, Close, Volume) of a pool based on the provided pool address on a network
    /// </remarks>
    public Task<Ohlcv> PoolOhlcvContractAddress(Timeframe timeframe,
        string? aggregate,
        int? beforeTimestamp,
        int? limit,
        Currency? currency,
        string? token,
        bool? includeEmptyIntervals,
        string network = "eth",
        string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{pool_address}/ohlcv/{timeframe}"),
            [new TemplateParam("network", network),
                new TemplateParam("pool_address", poolAddress),
                new TemplateParam("timeframe", timeframe)],
            [new Param("aggregate", aggregate),
                new Param("before_timestamp", beforeTimestamp),
                new Param("limit", limit),
                new Param("currency", currency),
                new Param("token", token),
                new Param("include_empty_intervals", includeEmptyIntervals)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Ohlcv>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Pool Tokens Info by Pool Address
    /// </summary>
    /// <param name="include">Attributes to include.</param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="poolAddress">Pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolTokensInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query pool metadata (base and quote token details, image, socials, websites, description, contract address, etc.) based on a provided pool contract address on a network
    /// </remarks>
    public Task<PoolTokensInfo> PoolTokenInfoContractAddress(Include2? include,
        string network = "solana",
        string poolAddress = "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{pool_address}/info"),
            [new TemplateParam("network", network), new TemplateParam("pool_address", poolAddress)],
            [new Param("include", include)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolTokensInfo>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Past 24 Hour Trades by Pool Address
    /// </summary>
    /// <param name="tradeVolumeInUsdGreaterThan">Filter trades by trade volume in USD greater than this value.  Default value: 0</param>
    /// <param name="token">Return trades for token, use this to invert the chart.  Available values: <c>base</c>, <c>quote</c>, or token address.  Default: <c>base</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="poolAddress">Pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Trades"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the last 300 trades in the past 24 hours based on the provided pool address
    /// </remarks>
    public Task<Trades> PoolTradesContractAddress(double? tradeVolumeInUsdGreaterThan,
        string? token,
        string network = "eth",
        string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/{pool_address}/trades"),
            [new TemplateParam("network", network), new TemplateParam("pool_address", poolAddress)],
            [new Param("trade_volume_in_usd_greater_than", tradeVolumeInUsdGreaterThan), new Param("token", token)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Trades>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Multiple Pools Data by Pool Addresses
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="includeVolumeBreakdown">Include volume breakdown.  Default: <c>false</c></param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="addresses">Pool contract address, comma-separated if more than one pool contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MultiPoolAddressData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query multiple pools based on the provided network and pool addresses
    /// </remarks>
    public Task<MultiPoolAddressData> PoolsAddresses(string? include,
        bool? includeVolumeBreakdown,
        bool? includeComposition,
        string network = "eth",
        string addresses = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools/multi/{addresses}"),
            [new TemplateParam("network", network), new TemplateParam("addresses", addresses)],
            [new Param("include", include),
                new Param("include_volume_breakdown", includeVolumeBreakdown),
                new Param("include_composition", includeComposition)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MultiPoolAddressData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Search Pools &amp; Tokens
    /// </summary>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="query">Search query: pool contract address, token name, token symbol, or token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PoolSearch"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To search for pools across all networks by pool address, token name, token symbol, or token contract address
    /// </remarks>
    public Task<PoolSearch> SearchPools(string? network,
        string? include,
        int? page,
        string? query = "weth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/search/pools"),
            [],
            [new Param("query", query),
                new Param("network", network),
                new Param("include", include),
                new Param("page", page)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PoolSearch>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Data by Token Address
    /// </summary>
    /// <param name="include">Attributes to include.</param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="includeInactiveSource">Include token data from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="address">Token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query specific token data based on the provided token contract address on a network
    /// </remarks>
    public Task<TokenData> TokenDataContractAddress(Include? include,
        bool? includeComposition,
        bool? includeInactiveSource,
        string network = "eth",
        string address = "0xdac17f958d2ee523a2206206994597c13d831ec7",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/{address}"),
            [new TemplateParam("network", network), new TemplateParam("address", address)],
            [new Param("include", include),
                new Param("include_composition", includeComposition),
                new Param("include_inactive_source", includeInactiveSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Token Info by Token Address
    /// </summary>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="address">Token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query token metadata (name, symbol, CoinGecko ID, image, socials, websites, description, etc.) based on a provided token contract address on a network
    /// </remarks>
    public Task<TokenInfo> TokenInfoContractAddress(string network = "solana",
        string address = "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/{address}/info"),
            [new TemplateParam("network", network), new TemplateParam("address", address)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenInfo>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Tokens Data by Token Addresses
    /// </summary>
    /// <param name="include">Attributes to include.</param>
    /// <param name="includeComposition">Include pool composition.  Default: <c>false</c></param>
    /// <param name="includeInactiveSource">Include tokens from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="addresses">Token contract address, comma-separated if more than one token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MultiTokenData"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query multiple tokens data based on the provided token contract addresses on a network
    /// </remarks>
    public Task<MultiTokenData> TokensDataContractAddresses(Include? include,
        bool? includeComposition,
        bool? includeInactiveSource,
        string network = "solana",
        string addresses = "6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/multi/{addresses}"),
            [new TemplateParam("network", network), new TemplateParam("addresses", addresses)],
            [new Param("include", include),
                new Param("include_composition", includeComposition),
                new Param("include_inactive_source", includeInactiveSource)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MultiTokenData>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Most Recently Updated Tokens List
    /// </summary>
    /// <param name="include">Attributes for related resources to include.</param>
    /// <param name="network">Filter tokens by provided network.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TokenInfoRecentlyUpdated"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query 100 most recently updated tokens info of a specific network or across all networks on GeckoTerminal
    /// </remarks>
    public Task<TokenInfoRecentlyUpdated> TokensInfoRecentUpdated(Include3? include,
        string? network,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/tokens/info_recently_updated"),
            [],
            [new Param("include", include), new Param("network", network)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TokenInfoRecentlyUpdated>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Top Pools by Token Address
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="includeInactiveSource">Include tokens from inactive pools using the most recent swap.  Default: <c>false</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="sort">Sort the pools by field.  Default: <c>h24_volume_usd_liquidity_desc</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="tokenAddress">Token contract address.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query top pools based on the provided token contract address on a network
    /// </remarks>
    public Task<Pool> TopPoolsContractAddress(string? include,
        bool? includeInactiveSource,
        int? page,
        Sort2? sort,
        bool? includeGtCommunityData,
        string network = "eth",
        string tokenAddress = "0xdac17f958d2ee523a2206206994597c13d831ec7",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/tokens/{token_address}/pools"),
            [new TemplateParam("network", network), new TemplateParam("token_address", tokenAddress)],
            [new Param("include", include),
                new Param("include_inactive_source", includeInactiveSource),
                new Param("page", page),
                new Param("sort", sort),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Top Pools by DEX
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="sort">Sort the pools by field.  Default: <c>h24_tx_count_desc</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="dex">DEX ID.  *refers to <see href="/reference/dexes-list"><c>/onchain/networks/{network}/dexes</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the top pools based on the provided network and decentralized exchange (DEX)
    /// </remarks>
    public Task<Pool> TopPoolsDex(string? include,
        int? page,
        Sort? sort,
        bool? includeGtCommunityData,
        string network = "eth",
        string dex = "sushiswap",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/dexes/{dex}/pools"),
            [new TemplateParam("network", network), new TemplateParam("dex", dex)],
            [new Param("include", include),
                new Param("page", page),
                new Param("sort", sort),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Top Pools by Network
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="sort">Sort the pools by field.  Default: <c>h24_tx_count_desc</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the top pools based on the provided network
    /// </remarks>
    public Task<Pool> TopPoolsNetwork(string? include,
        int? page,
        Sort? sort,
        bool? includeGtCommunityData,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/pools"),
            [new TemplateParam("network", network)],
            [new Param("include", include),
                new Param("page", page),
                new Param("sort", sort),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Trending Pools List
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c>, <c>network</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="duration">Duration to sort trending list by.  Default: <c>24h</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query all the trending pools across all networks on GeckoTerminal
    /// </remarks>
    public Task<Pool> TrendingPoolsList(string? include,
        int? page,
        Duration? duration,
        bool? includeGtCommunityData,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/trending_pools"),
            [],
            [new Param("include", include),
                new Param("page", page),
                new Param("duration", duration),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Trending Pools by Network
    /// </summary>
    /// <param name="include">Attributes to include, comma-separated if more than one.  Available values: <c>base_token</c>, <c>quote_token</c>, <c>dex</c></param>
    /// <param name="page">Page through results.  Default value: 1</param>
    /// <param name="duration">Duration to sort trending list by.  Default: <c>24h</c></param>
    /// <param name="includeGtCommunityData">Include GeckoTerminal community data (sentiment votes, suspicious reports).  Default: <c>false</c></param>
    /// <param name="network">Network ID.  *refers to <see href="/reference/networks-list"><c>/onchain/networks</c></see>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pool"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// To query the trending pools based on the provided network
    /// </remarks>
    public Task<Pool> TrendingPoolsNetwork(string? include,
        int? page,
        Duration? duration,
        bool? includeGtCommunityData,
        string network = "eth",
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/onchain/networks/{network}/trending_pools"),
            [new TemplateParam("network", network)],
            [new Param("include", include),
                new Param("page", page),
                new Param("duration", duration),
                new Param("include_gt_community_data", includeGtCommunityData)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pool>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.HeaderAuth, _auth.QueryAuth)],
            requestOptions,
            ct);
}
