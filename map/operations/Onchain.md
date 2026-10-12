<!-- Generated file — do not edit; regenerated with the SDK. -->

# Onchain — operations

Accessor: `client.Onchain` · Source: `src/CoinGecko/Api/Onchain.cs` · 20 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DexesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DexesList(DexesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`
- **Returns**: `DexesList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DexesListRequest` | `src/CoinGecko/Requests/Onchain/DexesListRequest.cs` |
| `DexesList` | `src/CoinGecko/Models/DexesList.cs` |

### LatestPoolsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `LatestPoolsList(LatestPoolsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LatestPoolsListRequest` | `src/CoinGecko/Requests/Onchain/LatestPoolsListRequest.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

### LatestPoolsNetwork

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `LatestPoolsNetwork(LatestPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LatestPoolsNetworkRequest` | `src/CoinGecko/Requests/Onchain/LatestPoolsNetworkRequest.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

### NetworksList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NetworksList(NetworksListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`
- **Returns**: `NetworksList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NetworksListRequest` | `src/CoinGecko/Requests/Onchain/NetworksListRequest.cs` |
| `NetworksList` | `src/CoinGecko/Models/NetworksList.cs` |

### OnchainSimplePrice

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `OnchainSimplePrice(OnchainSimplePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_market_cap` ← `IncludeMarketCap`, `mcap_fdv_fallback` ← `McapFdvFallback`, `include_24hr_vol` ← `Include24HrVol`, `include_24hr_price_change` ← `Include24HrPriceChange`, `include_total_reserve_in_usd` ← `IncludeTotalReserveInUsd`, `include_inactive_source` ← `IncludeInactiveSource`
- **Returns**: `OnchainSimplePrice`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OnchainSimplePriceRequest` | `src/CoinGecko/Requests/Onchain/OnchainSimplePriceRequest.cs` |
| `OnchainSimplePrice` | `src/CoinGecko/Models/OnchainSimplePrice.cs` |

### PoolAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolAddress(PoolAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_volume_breakdown` ← `IncludeVolumeBreakdown`, `include_composition` ← `IncludeComposition`
- **Returns**: `PoolAddressData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolAddressRequest` | `src/CoinGecko/Requests/Onchain/PoolAddressRequest.cs` |
| `PoolAddressData` | `src/CoinGecko/Models/PoolAddressData.cs` |

### PoolOhlcvContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolOhlcvContractAddress(PoolOhlcvContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `aggregate` ← `Aggregate`, `before_timestamp` ← `BeforeTimestamp`, `limit` ← `Limit`, `currency` ← `Currency`, `token` ← `Token`, `include_empty_intervals` ← `IncludeEmptyIntervals`
- **Returns**: `Ohlcv`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolOhlcvContractAddressRequest` | `src/CoinGecko/Requests/Onchain/PoolOhlcvContractAddressRequest.cs` |
| `Timeframe` | `src/CoinGecko/Models/Enums/Timeframe.cs` |
| `Currency` | `src/CoinGecko/Models/Enums/Currency.cs` |
| `Ohlcv` | `src/CoinGecko/Models/Ohlcv.cs` |

### PoolTokenInfoContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolTokenInfoContractAddress(PoolTokenInfoContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `PoolTokensInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolTokenInfoContractAddressRequest` | `src/CoinGecko/Requests/Onchain/PoolTokenInfoContractAddressRequest.cs` |
| `Include2` | `src/CoinGecko/Models/Enums/Include2.cs` |
| `PoolTokensInfo` | `src/CoinGecko/Models/PoolTokensInfo.cs` |

### PoolTradesContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolTradesContractAddress(PoolTradesContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `trade_volume_in_usd_greater_than` ← `TradeVolumeInUsdGreaterThan`, `token` ← `Token`
- **Returns**: `Trades`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolTradesContractAddressRequest` | `src/CoinGecko/Requests/Onchain/PoolTradesContractAddressRequest.cs` |
| `Trades` | `src/CoinGecko/Models/Trades.cs` |

### PoolsAddresses

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolsAddresses(PoolsAddressesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_volume_breakdown` ← `IncludeVolumeBreakdown`, `include_composition` ← `IncludeComposition`
- **Returns**: `MultiPoolAddressData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolsAddressesRequest` | `src/CoinGecko/Requests/Onchain/PoolsAddressesRequest.cs` |
| `MultiPoolAddressData` | `src/CoinGecko/Models/MultiPoolAddressData.cs` |

### SearchPools

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SearchPools(SearchPoolsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `query` ← `Query`, `network` ← `Network`, `include` ← `Include`, `page` ← `Page`
- **Returns**: `PoolSearch`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchPoolsRequest` | `src/CoinGecko/Requests/Onchain/SearchPoolsRequest.cs` |
| `PoolSearch` | `src/CoinGecko/Models/PoolSearch.cs` |

### TokenDataContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokenDataContractAddress(TokenDataContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_composition` ← `IncludeComposition`, `include_inactive_source` ← `IncludeInactiveSource`
- **Returns**: `TokenData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenDataContractAddressRequest` | `src/CoinGecko/Requests/Onchain/TokenDataContractAddressRequest.cs` |
| `Include` | `src/CoinGecko/Models/Enums/Include.cs` |
| `TokenData` | `src/CoinGecko/Models/TokenData.cs` |

### TokenInfoContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokenInfoContractAddress(TokenInfoContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TokenInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenInfoContractAddressRequest` | `src/CoinGecko/Requests/Onchain/TokenInfoContractAddressRequest.cs` |
| `TokenInfo` | `src/CoinGecko/Models/TokenInfo.cs` |

### TokensDataContractAddresses

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokensDataContractAddresses(TokensDataContractAddressesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_composition` ← `IncludeComposition`, `include_inactive_source` ← `IncludeInactiveSource`
- **Returns**: `MultiTokenData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokensDataContractAddressesRequest` | `src/CoinGecko/Requests/Onchain/TokensDataContractAddressesRequest.cs` |
| `Include` | `src/CoinGecko/Models/Enums/Include.cs` |
| `MultiTokenData` | `src/CoinGecko/Models/MultiTokenData.cs` |

### TokensInfoRecentUpdated

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokensInfoRecentUpdated(TokensInfoRecentUpdatedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `network` ← `Network`
- **Returns**: `TokenInfoRecentlyUpdated`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokensInfoRecentUpdatedRequest` | `src/CoinGecko/Requests/Onchain/TokensInfoRecentUpdatedRequest.cs` |
| `Include3` | `src/CoinGecko/Models/Enums/Include3.cs` |
| `TokenInfoRecentlyUpdated` | `src/CoinGecko/Models/TokenInfoRecentlyUpdated.cs` |

### TopPoolsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TopPoolsContractAddress(TopPoolsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_inactive_source` ← `IncludeInactiveSource`, `page` ← `Page`, `sort` ← `Sort`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopPoolsContractAddressRequest` | `src/CoinGecko/Requests/Onchain/TopPoolsContractAddressRequest.cs` |
| `Sort2` | `src/CoinGecko/Models/Enums/Sort2.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

### TopPoolsDex

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TopPoolsDex(TopPoolsDexRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `sort` ← `Sort`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopPoolsDexRequest` | `src/CoinGecko/Requests/Onchain/TopPoolsDexRequest.cs` |
| `Sort` | `src/CoinGecko/Models/Enums/Sort.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

### TopPoolsNetwork

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TopPoolsNetwork(TopPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `sort` ← `Sort`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopPoolsNetworkRequest` | `src/CoinGecko/Requests/Onchain/TopPoolsNetworkRequest.cs` |
| `Sort` | `src/CoinGecko/Models/Enums/Sort.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

### TrendingPoolsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TrendingPoolsList(TrendingPoolsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `duration` ← `Duration`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingPoolsListRequest` | `src/CoinGecko/Requests/Onchain/TrendingPoolsListRequest.cs` |
| `Duration` | `src/CoinGecko/Models/Enums/Duration.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

### TrendingPoolsNetwork

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TrendingPoolsNetwork(TrendingPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `duration` ← `Duration`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingPoolsNetworkRequest` | `src/CoinGecko/Requests/Onchain/TrendingPoolsNetworkRequest.cs` |
| `Duration` | `src/CoinGecko/Models/Enums/Duration.cs` |
| `Pool` | `src/CoinGecko/Models/Pool.cs` |

