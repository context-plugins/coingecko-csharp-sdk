<!-- Generated file — do not edit; regenerated with the SDK. -->

# Onchain — operations

Accessor: `client.Onchain` · Source: `Api/Onchain.cs` · 20 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DexesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DexesList(DexesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`
- **Returns**: `DexesList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DexesListRequest` | `Requests/Onchain/DexesListRequest.cs` |
| `DexesList` | `Models/DexesList.cs` |

### LatestPoolsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `LatestPoolsList(LatestPoolsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LatestPoolsListRequest` | `Requests/Onchain/LatestPoolsListRequest.cs` |
| `Pool` | `Models/Pool.cs` |

### LatestPoolsNetwork

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `LatestPoolsNetwork(LatestPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LatestPoolsNetworkRequest` | `Requests/Onchain/LatestPoolsNetworkRequest.cs` |
| `Pool` | `Models/Pool.cs` |

### NetworksList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NetworksList(NetworksListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `page` ← `Page`
- **Returns**: `NetworksList`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NetworksListRequest` | `Requests/Onchain/NetworksListRequest.cs` |
| `NetworksList` | `Models/NetworksList.cs` |

### OnchainSimplePrice

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `OnchainSimplePrice(OnchainSimplePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_market_cap` ← `IncludeMarketCap`, `mcap_fdv_fallback` ← `McapFdvFallback`, `include_24hr_vol` ← `Include24HrVol`, `include_24hr_price_change` ← `Include24HrPriceChange`, `include_total_reserve_in_usd` ← `IncludeTotalReserveInUsd`, `include_inactive_source` ← `IncludeInactiveSource`
- **Returns**: `OnchainSimplePrice`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OnchainSimplePriceRequest` | `Requests/Onchain/OnchainSimplePriceRequest.cs` |
| `OnchainSimplePrice` | `Models/OnchainSimplePrice.cs` |

### PoolAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolAddress(PoolAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_volume_breakdown` ← `IncludeVolumeBreakdown`, `include_composition` ← `IncludeComposition`
- **Returns**: `PoolAddressData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolAddressRequest` | `Requests/Onchain/PoolAddressRequest.cs` |
| `PoolAddressData` | `Models/PoolAddressData.cs` |

### PoolOhlcvContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolOhlcvContractAddress(PoolOhlcvContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `aggregate` ← `Aggregate`, `before_timestamp` ← `BeforeTimestamp`, `limit` ← `Limit`, `currency` ← `Currency`, `token` ← `Token`, `include_empty_intervals` ← `IncludeEmptyIntervals`
- **Returns**: `Ohlcv`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolOhlcvContractAddressRequest` | `Requests/Onchain/PoolOhlcvContractAddressRequest.cs` |
| `Timeframe` | `Models/Enums/Timeframe.cs` |
| `Currency` | `Models/Enums/Currency.cs` |
| `Ohlcv` | `Models/Ohlcv.cs` |

### PoolTokenInfoContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolTokenInfoContractAddress(PoolTokenInfoContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`
- **Returns**: `PoolTokensInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolTokenInfoContractAddressRequest` | `Requests/Onchain/PoolTokenInfoContractAddressRequest.cs` |
| `Include2` | `Models/Enums/Include2.cs` |
| `PoolTokensInfo` | `Models/PoolTokensInfo.cs` |

### PoolTradesContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolTradesContractAddress(PoolTradesContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `trade_volume_in_usd_greater_than` ← `TradeVolumeInUsdGreaterThan`, `token` ← `Token`
- **Returns**: `Trades`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolTradesContractAddressRequest` | `Requests/Onchain/PoolTradesContractAddressRequest.cs` |
| `Trades` | `Models/Trades.cs` |

### PoolsAddresses

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PoolsAddresses(PoolsAddressesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_volume_breakdown` ← `IncludeVolumeBreakdown`, `include_composition` ← `IncludeComposition`
- **Returns**: `MultiPoolAddressData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolsAddressesRequest` | `Requests/Onchain/PoolsAddressesRequest.cs` |
| `MultiPoolAddressData` | `Models/MultiPoolAddressData.cs` |

### SearchPools

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SearchPools(SearchPoolsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `query` ← `Query`, `network` ← `Network`, `include` ← `Include`, `page` ← `Page`
- **Returns**: `PoolSearch`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchPoolsRequest` | `Requests/Onchain/SearchPoolsRequest.cs` |
| `PoolSearch` | `Models/PoolSearch.cs` |

### TokenDataContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokenDataContractAddress(TokenDataContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_composition` ← `IncludeComposition`, `include_inactive_source` ← `IncludeInactiveSource`
- **Returns**: `TokenData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenDataContractAddressRequest` | `Requests/Onchain/TokenDataContractAddressRequest.cs` |
| `Include` | `Models/Enums/Include.cs` |
| `TokenData` | `Models/TokenData.cs` |

### TokenInfoContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokenInfoContractAddress(TokenInfoContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TokenInfo`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenInfoContractAddressRequest` | `Requests/Onchain/TokenInfoContractAddressRequest.cs` |
| `TokenInfo` | `Models/TokenInfo.cs` |

### TokensDataContractAddresses

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokensDataContractAddresses(TokensDataContractAddressesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_composition` ← `IncludeComposition`, `include_inactive_source` ← `IncludeInactiveSource`
- **Returns**: `MultiTokenData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokensDataContractAddressesRequest` | `Requests/Onchain/TokensDataContractAddressesRequest.cs` |
| `Include` | `Models/Enums/Include.cs` |
| `MultiTokenData` | `Models/MultiTokenData.cs` |

### TokensInfoRecentUpdated

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokensInfoRecentUpdated(TokensInfoRecentUpdatedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `network` ← `Network`
- **Returns**: `TokenInfoRecentlyUpdated`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokensInfoRecentUpdatedRequest` | `Requests/Onchain/TokensInfoRecentUpdatedRequest.cs` |
| `Include3` | `Models/Enums/Include3.cs` |
| `TokenInfoRecentlyUpdated` | `Models/TokenInfoRecentlyUpdated.cs` |

### TopPoolsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TopPoolsContractAddress(TopPoolsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `include_inactive_source` ← `IncludeInactiveSource`, `page` ← `Page`, `sort` ← `Sort`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopPoolsContractAddressRequest` | `Requests/Onchain/TopPoolsContractAddressRequest.cs` |
| `Sort2` | `Models/Enums/Sort2.cs` |
| `Pool` | `Models/Pool.cs` |

### TopPoolsDex

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TopPoolsDex(TopPoolsDexRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `sort` ← `Sort`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopPoolsDexRequest` | `Requests/Onchain/TopPoolsDexRequest.cs` |
| `Sort` | `Models/Enums/Sort.cs` |
| `Pool` | `Models/Pool.cs` |

### TopPoolsNetwork

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TopPoolsNetwork(TopPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `sort` ← `Sort`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TopPoolsNetworkRequest` | `Requests/Onchain/TopPoolsNetworkRequest.cs` |
| `Sort` | `Models/Enums/Sort.cs` |
| `Pool` | `Models/Pool.cs` |

### TrendingPoolsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TrendingPoolsList(TrendingPoolsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `duration` ← `Duration`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingPoolsListRequest` | `Requests/Onchain/TrendingPoolsListRequest.cs` |
| `Duration` | `Models/Enums/Duration.cs` |
| `Pool` | `Models/Pool.cs` |

### TrendingPoolsNetwork

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TrendingPoolsNetwork(TrendingPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include` ← `Include`, `page` ← `Page`, `duration` ← `Duration`, `include_gt_community_data` ← `IncludeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingPoolsNetworkRequest` | `Requests/Onchain/TrendingPoolsNetworkRequest.cs` |
| `Duration` | `Models/Enums/Duration.cs` |
| `Pool` | `Models/Pool.cs` |

