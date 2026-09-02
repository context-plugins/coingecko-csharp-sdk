<!-- Generated file — do not edit; regenerated with the SDK. -->

# Onchain — operations

Accessor: `client.Onchain` · Source: `Api/Onchain.cs` · 20 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DexesList

- **Signature**: `DexesList(int? page, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"eth"`
- **Query params (wire ← C#)**: `page` ← `page`
- **Returns**: `DexesList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DexesList` | `Models/DexesList.cs` |

### LatestPoolsList

- **Signature**: `LatestPoolsList(string? include, int? page, bool? includeGtCommunityData, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `includeGtCommunityData` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Pool` | `Models/Pool.cs` |

### LatestPoolsNetwork

- **Signature**: `LatestPoolsNetwork(string? include, int? page, bool? includeGtCommunityData, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `includeGtCommunityData` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"eth"`
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Pool` | `Models/Pool.cs` |

### NetworksList

- **Signature**: `NetworksList(int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`
- **Returns**: `NetworksList`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NetworksList` | `Models/NetworksList.cs` |

### OnchainSimplePrice

- **Signature**: `OnchainSimplePrice(bool? includeMarketCap, bool? mcapFdvFallback, bool? include24HrVol, bool? include24HrPriceChange, bool? includeTotalReserveInUsd, bool? includeInactiveSource, string network = "eth", string addresses = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`includeMarketCap` … `includeInactiveSource`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `network` = `"eth"`, `addresses` = `"0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2"`
- **Query params (wire ← C#)**: `include_market_cap` ← `includeMarketCap`, `mcap_fdv_fallback` ← `mcapFdvFallback`, `include_24hr_vol` ← `include24HrVol`, `include_24hr_price_change` ← `include24HrPriceChange`, `include_total_reserve_in_usd` ← `includeTotalReserveInUsd`, `include_inactive_source` ← `includeInactiveSource`
- **Returns**: `OnchainSimplePrice`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OnchainSimplePrice` | `Models/OnchainSimplePrice.cs` |

### PoolAddress

- **Signature**: `PoolAddress(string? include, bool? includeVolumeBreakdown, bool? includeComposition, string network = "eth", string address = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `includeVolumeBreakdown` — nullable, no default → **must pass explicitly**
  - `includeComposition` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"eth"`, `address` = `"0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640"`
- **Query params (wire ← C#)**: `include` ← `include`, `include_volume_breakdown` ← `includeVolumeBreakdown`, `include_composition` ← `includeComposition`
- **Returns**: `PoolAddressData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolAddressData` | `Models/PoolAddressData.cs` |

### PoolOhlcvContractAddress

- **Signature**: `PoolOhlcvContractAddress(Timeframe timeframe, string? aggregate, int? beforeTimestamp, int? limit, Currency? currency, string? token, bool? includeEmptyIntervals, string network = "eth", string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`aggregate` … `includeEmptyIntervals`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `network` = `"eth"`, `poolAddress` = `"0x06da0fd433c1a5d7a4faa01111c044910a184553"`
- **Query params (wire ← C#)**: `aggregate` ← `aggregate`, `before_timestamp` ← `beforeTimestamp`, `limit` ← `limit`, `currency` ← `currency`, `token` ← `token`, `include_empty_intervals` ← `includeEmptyIntervals`
- **Returns**: `Ohlcv`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Timeframe` | `Models/Enums/Timeframe.cs` |
| `Currency` | `Models/Enums/Currency.cs` |
| `Ohlcv` | `Models/Ohlcv.cs` |

### PoolTokenInfoContractAddress

- **Signature**: `PoolTokenInfoContractAddress(Include2? include, string network = "solana", string poolAddress = "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"solana"`, `poolAddress` = `"8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt"`
- **Query params (wire ← C#)**: `include` ← `include`
- **Returns**: `PoolTokensInfo`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Include2` | `Models/Enums/Include2.cs` |
| `PoolTokensInfo` | `Models/PoolTokensInfo.cs` |

### PoolTradesContractAddress

- **Signature**: `PoolTradesContractAddress(double? tradeVolumeInUsdGreaterThan, string? token, string network = "eth", string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `tradeVolumeInUsdGreaterThan` — nullable, no default → **must pass explicitly**
  - `token` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"eth"`, `poolAddress` = `"0x06da0fd433c1a5d7a4faa01111c044910a184553"`
- **Query params (wire ← C#)**: `trade_volume_in_usd_greater_than` ← `tradeVolumeInUsdGreaterThan`, `token` ← `token`
- **Returns**: `Trades`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Trades` | `Models/Trades.cs` |

### PoolsAddresses

- **Signature**: `PoolsAddresses(string? include, bool? includeVolumeBreakdown, bool? includeComposition, string network = "eth", string addresses = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `includeVolumeBreakdown` — nullable, no default → **must pass explicitly**
  - `includeComposition` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"eth"`, `addresses` = `"0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640"`
- **Query params (wire ← C#)**: `include` ← `include`, `include_volume_breakdown` ← `includeVolumeBreakdown`, `include_composition` ← `includeComposition`
- **Returns**: `MultiPoolAddressData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MultiPoolAddressData` | `Models/MultiPoolAddressData.cs` |

### SearchPools

- **Signature**: `SearchPools(string? network, string? include, int? page, string? query = "weth", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `network` — nullable, no default → **must pass explicitly**
  - `include` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - defaults: `query` = `"weth"`
- **Query params (wire ← C#)**: `query` ← `query`, `network` ← `network`, `include` ← `include`, `page` ← `page`
- **Returns**: `PoolSearch`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PoolSearch` | `Models/PoolSearch.cs` |

### TokenDataContractAddress

- **Signature**: `TokenDataContractAddress(Include? include, bool? includeComposition, bool? includeInactiveSource, string network = "eth", string address = "0xdac17f958d2ee523a2206206994597c13d831ec7", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `includeComposition` — nullable, no default → **must pass explicitly**
  - `includeInactiveSource` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"eth"`, `address` = `"0xdac17f958d2ee523a2206206994597c13d831ec7"`
- **Query params (wire ← C#)**: `include` ← `include`, `include_composition` ← `includeComposition`, `include_inactive_source` ← `includeInactiveSource`
- **Returns**: `TokenData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Include` | `Models/Enums/Include.cs` |
| `TokenData` | `Models/TokenData.cs` |

### TokenInfoContractAddress

- **Signature**: `TokenInfoContractAddress(string network = "solana", string address = "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `network` = `"solana"`, `address` = `"Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump"`
- **Returns**: `TokenInfo`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenInfo` | `Models/TokenInfo.cs` |

### TokensDataContractAddresses

- **Signature**: `TokensDataContractAddresses(Include? include, bool? includeComposition, bool? includeInactiveSource, string network = "solana", string addresses = "6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `includeComposition` — nullable, no default → **must pass explicitly**
  - `includeInactiveSource` — nullable, no default → **must pass explicitly**
  - defaults: `network` = `"solana"`, `addresses` = `"6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump"`
- **Query params (wire ← C#)**: `include` ← `include`, `include_composition` ← `includeComposition`, `include_inactive_source` ← `includeInactiveSource`
- **Returns**: `MultiTokenData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Include` | `Models/Enums/Include.cs` |
| `MultiTokenData` | `Models/MultiTokenData.cs` |

### TokensInfoRecentUpdated

- **Signature**: `TokensInfoRecentUpdated(Include3? include, string? network, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `include` — nullable, no default → **must pass explicitly**
  - `network` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include` ← `include`, `network` ← `network`
- **Returns**: `TokenInfoRecentlyUpdated`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Include3` | `Models/Enums/Include3.cs` |
| `TokenInfoRecentlyUpdated` | `Models/TokenInfoRecentlyUpdated.cs` |

### TopPoolsContractAddress

- **Signature**: `TopPoolsContractAddress(string? include, bool? includeInactiveSource, int? page, Sort2? sort, bool? includeGtCommunityData, string network = "eth", string tokenAddress = "0xdac17f958d2ee523a2206206994597c13d831ec7", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`include` … `includeGtCommunityData`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `network` = `"eth"`, `tokenAddress` = `"0xdac17f958d2ee523a2206206994597c13d831ec7"`
- **Query params (wire ← C#)**: `include` ← `include`, `include_inactive_source` ← `includeInactiveSource`, `page` ← `page`, `sort` ← `sort`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Sort2` | `Models/Enums/Sort2.cs` |
| `Pool` | `Models/Pool.cs` |

### TopPoolsDex

- **Signature**: `TopPoolsDex(string? include, int? page, Sort? sort, bool? includeGtCommunityData, string network = "eth", string dex = "sushiswap", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`include` … `includeGtCommunityData`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `network` = `"eth"`, `dex` = `"sushiswap"`
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `sort` ← `sort`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Sort` | `Models/Enums/Sort.cs` |
| `Pool` | `Models/Pool.cs` |

### TopPoolsNetwork

- **Signature**: `TopPoolsNetwork(string? include, int? page, Sort? sort, bool? includeGtCommunityData, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`include` … `includeGtCommunityData`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `network` = `"eth"`
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `sort` ← `sort`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Sort` | `Models/Enums/Sort.cs` |
| `Pool` | `Models/Pool.cs` |

### TrendingPoolsList

- **Signature**: `TrendingPoolsList(string? include, int? page, Duration? duration, bool? includeGtCommunityData, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`include` … `includeGtCommunityData`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `duration` ← `duration`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Duration` | `Models/Enums/Duration.cs` |
| `Pool` | `Models/Pool.cs` |

### TrendingPoolsNetwork

- **Signature**: `TrendingPoolsNetwork(string? include, int? page, Duration? duration, bool? includeGtCommunityData, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`include` … `includeGtCommunityData`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `network` = `"eth"`
- **Query params (wire ← C#)**: `include` ← `include`, `page` ← `page`, `duration` ← `duration`, `include_gt_community_data` ← `includeGtCommunityData`
- **Returns**: `Pool`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Duration` | `Models/Enums/Duration.cs` |
| `Pool` | `Models/Pool.cs` |

