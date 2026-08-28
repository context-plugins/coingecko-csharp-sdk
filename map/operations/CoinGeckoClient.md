<!-- Generated file — do not edit; regenerated with the SDK. -->

# CoinGeckoClient — operations

Accessor: `client` · Source: `CoinGeckoClient.cs` · 61 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssetPlatformsList

- **Signature**: `AssetPlatformsList(Filter? filter, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filter` ← `filter`
- **Returns**: `IReadOnlyList<AssetPlatform>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Filter` | `Models/Enums/Filter.cs` |
| `AssetPlatform` | `Models/AssetPlatform.cs` |

### CoinsCategories

- **Signature**: `CoinsCategories(Order2? order, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `order` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `order` ← `order`
- **Returns**: `IReadOnlyList<Category1>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order2` | `Models/Enums/Order2.cs` |
| `Category1` | `Models/Category1.cs` |

### CoinsCategoriesList

- **Signature**: `CoinsCategoriesList(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<CategoriesList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesList` | `Models/CategoriesList.cs` |

### CoinsContractAddress

- **Signature**: `CoinsContractAddress(string id = "ethereum", string contractAddress = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `id` = `"ethereum"`, `contractAddress` = `"0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2"`
- **Returns**: `CoinsContractAddress`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsContractAddress` | `Models/CoinsContractAddress.cs` |

### CoinsId

- **Signature**: `CoinsId(bool? localization, bool? tickers, bool? marketData, bool? communityData, bool? developerData, bool? sparkline, bool? includeCategoriesDetails, DexPairFormat? dexPairFormat, string id = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`localization` … `dexPairFormat`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `id` = `"bitcoin"`
- **Query params (wire ← C#)**: `localization` ← `localization`, `tickers` ← `tickers`, `market_data` ← `marketData`, `community_data` ← `communityData`, `developer_data` ← `developerData`, `sparkline` ← `sparkline`, `include_categories_details` ← `includeCategoriesDetails`, `dex_pair_format` ← `dexPairFormat`
- **Returns**: `CoinsId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `CoinsId` | `Models/CoinsId.cs` |

### CoinsIdHistory

- **Signature**: `CoinsIdHistory(bool? localization, string id = "bitcoin", string date = "30-12-2025", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `localization` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"bitcoin"`, `date` = `"30-12-2025"`
- **Query params (wire ← C#)**: `date` ← `date`, `localization` ← `localization`
- **Returns**: `CoinsIdHistory`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdHistory` | `Models/CoinsIdHistory.cs` |

### CoinsIdMarketChart

- **Signature**: `CoinsIdMarketChart(Interval? interval, Precision? precision, string id = "bitcoin", string vsCurrency = "usd", string days = "1", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `interval` — nullable, no default → **must pass explicitly**
  - `precision` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"bitcoin"`, `vsCurrency` = `"usd"`, `days` = `"1"`
- **Query params (wire ← C#)**: `vs_currency` ← `vsCurrency`, `days` ← `days`, `interval` ← `interval`, `precision` ← `precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Interval` | `Models/Enums/Interval.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### CoinsIdMarketChartRange

- **Signature**: `CoinsIdMarketChartRange(Precision? precision, string id = "bitcoin", string vsCurrency = "usd", int from = 1767024000, int to = 1777564800, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `precision` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"bitcoin"`, `vsCurrency` = `"usd"`, `from` = `1767024000`, `to` = `1777564800`
- **Query params (wire ← C#)**: `vs_currency` ← `vsCurrency`, `from` ← `from`, `to` ← `to`, `precision` ← `precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### CoinsIdOhlc

- **Signature**: `CoinsIdOhlc(Days days, Precision? precision, string id = "bitcoin", string vsCurrency = "usd", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `precision` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"bitcoin"`, `vsCurrency` = `"usd"`
- **Query params (wire ← C#)**: `vs_currency` ← `vsCurrency`, `days` ← `days`, `precision` ← `precision`
- **Returns**: `IReadOnlyList<IReadOnlyList<double>>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Days` | `Models/Enums/Days.cs` |
| `Precision` | `Models/Enums/Precision.cs` |

### CoinsIdTickers

- **Signature**: `CoinsIdTickers(string? exchangeIds, bool? includeExchangeLogo, int? page, Order1? order, bool? depth, DexPairFormat? dexPairFormat, string id = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`exchangeIds` … `dexPairFormat`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `id` = `"bitcoin"`
- **Query params (wire ← C#)**: `exchange_ids` ← `exchangeIds`, `include_exchange_logo` ← `includeExchangeLogo`, `page` ← `page`, `order` ← `order`, `depth` ← `depth`, `dex_pair_format` ← `dexPairFormat`
- **Returns**: `CoinsIdTickers`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order1` | `Models/Enums/Order1.cs` |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `CoinsIdTickers` | `Models/CoinsIdTickers.cs` |

### CoinsList

- **Signature**: `CoinsList(bool? includePlatform, Status? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includePlatform` — nullable, no default → **must pass explicitly**
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `include_platform` ← `includePlatform`, `status` ← `status`
- **Returns**: `IReadOnlyList<CoinsList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Status` | `Models/Enums/Status.cs` |
| `CoinsList` | `Models/CoinsList.cs` |

### CoinsMarkets

- **Signature**: `CoinsMarkets(IncludeTokens? includeTokens, string? category, Order? order, int? perPage, int? page, bool? sparkline, string? priceChangePercentage, Locale? locale, Precision? precision, bool? includeRehypothecated, string vsCurrency = "usd", string? ids = "bitcoin", string? names = "Bitcoin", string? symbols = "btc", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`includeTokens` … `includeRehypothecated`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `vsCurrency` = `"usd"`, `ids` = `"bitcoin"`, `names` = `"Bitcoin"`, `symbols` = `"btc"`
- **Query params (wire ← C#)**: `vs_currency` ← `vsCurrency`, `ids` ← `ids`, `names` ← `names`, `symbols` ← `symbols`, `include_tokens` ← `includeTokens`, `category` ← `category`, `order` ← `order`, `per_page` ← `perPage`, `page` ← `page`, `sparkline` ← `sparkline`, `price_change_percentage` ← `priceChangePercentage`, `locale` ← `locale`, `precision` ← `precision`, `include_rehypothecated` ← `includeRehypothecated`
- **Returns**: `IReadOnlyList<CoinsMarket>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncludeTokens` | `Models/Enums/IncludeTokens.cs` |
| `Order` | `Models/Enums/Order.cs` |
| `Locale` | `Models/Enums/Locale.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarket` | `Models/CoinsMarket.cs` |

### CompaniesPublicTreasury

- **Signature**: `CompaniesPublicTreasury(Entity entity, int? perPage, int? page, Order5? order, string coinId = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `order` — nullable, no default → **must pass explicitly**
  - defaults: `coinId` = `"bitcoin"`
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`, `order` ← `order`
- **Returns**: `PublicTreasury`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Entity` | `Models/Enums/Entity.cs` |
| `Order5` | `Models/Enums/Order5.cs` |
| `PublicTreasury` | `Models/AnyOf/PublicTreasury.cs` |

### ContractAddressMarketChart

- **Signature**: `ContractAddressMarketChart(Interval? interval, Precision? precision, string id = "ethereum", string contractAddress = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48", string vsCurrency = "usd", string days = "1", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `interval` — nullable, no default → **must pass explicitly**
  - `precision` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"ethereum"`, `contractAddress` = `"0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48"`, `vsCurrency` = `"usd"`, `days` = `"1"`
- **Query params (wire ← C#)**: `vs_currency` ← `vsCurrency`, `days` ← `days`, `interval` ← `interval`, `precision` ← `precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Interval` | `Models/Enums/Interval.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### ContractAddressMarketChartRange

- **Signature**: `ContractAddressMarketChartRange(Precision? precision, string id = "ethereum", string contractAddress = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48", string vsCurrency = "usd", int from = 1767024000, int to = 1777564800, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `precision` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"ethereum"`, `contractAddress` = `"0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48"`, `vsCurrency` = `"usd"`, `from` = `1767024000`, `to` = `1777564800`
- **Query params (wire ← C#)**: `vs_currency` ← `vsCurrency`, `from` ← `from`, `to` ← `to`, `precision` ← `precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### CryptoGlobal

- **Signature**: `CryptoGlobal(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Global`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Global` | `Models/Global.cs` |

### DerivativesExchanges

- **Signature**: `DerivativesExchanges(Order4? order, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `order` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `order` ← `order`, `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<DerivativesExchange>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order4` | `Models/Enums/Order4.cs` |
| `DerivativesExchange` | `Models/DerivativesExchange.cs` |

### DerivativesExchangesId

- **Signature**: `DerivativesExchangesId(IncludeTickers? includeTickers, string id = "binance_futures", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeTickers` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"binance_futures"`
- **Query params (wire ← C#)**: `include_tickers` ← `includeTickers`
- **Returns**: `DerivativesExchangesId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncludeTickers` | `Models/Enums/IncludeTickers.cs` |
| `DerivativesExchangesId` | `Models/DerivativesExchangesId.cs` |

### DerivativesExchangesList

- **Signature**: `DerivativesExchangesList(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DerivativesExchangesList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesList` | `Models/DerivativesExchangesList.cs` |

### DerivativesTickers

- **Signature**: `DerivativesTickers(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<DerivativesTicker>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesTicker` | `Models/DerivativesTicker.cs` |

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

### EntitiesList

- **Signature**: `EntitiesList(EntityType? entityType, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `entityType` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `entity_type` ← `entityType`, `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<EntitiesList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EntityType` | `Models/Enums/EntityType.cs` |
| `EntitiesList` | `Models/EntitiesList.cs` |

### ExchangeRates

- **Signature**: `ExchangeRates(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ExchangeRates`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangeRates` | `Models/ExchangeRates.cs` |

### Exchanges

- **Signature**: `Exchanges(double? perPage, double? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<Exchange1>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Exchange1` | `Models/Exchange1.cs` |

### ExchangesId

- **Signature**: `ExchangesId(DexPairFormat? dexPairFormat, string id = "binance", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `dexPairFormat` — nullable, no default → **must pass explicitly**
  - defaults: `id` = `"binance"`
- **Query params (wire ← C#)**: `dex_pair_format` ← `dexPairFormat`
- **Returns**: `ExchangesId`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `ExchangesId` | `Models/ExchangesId.cs` |

### ExchangesIdTickers

- **Signature**: `ExchangesIdTickers(string? coinIds, bool? includeExchangeLogo, double? page, bool? depth, Order3? order, DexPairFormat? dexPairFormat, string id = "binance", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`coinIds` … `dexPairFormat`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `id` = `"binance"`
- **Query params (wire ← C#)**: `coin_ids` ← `coinIds`, `include_exchange_logo` ← `includeExchangeLogo`, `page` ← `page`, `depth` ← `depth`, `order` ← `order`, `dex_pair_format` ← `dexPairFormat`
- **Returns**: `CoinsIdTickers`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order3` | `Models/Enums/Order3.cs` |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `CoinsIdTickers` | `Models/CoinsIdTickers.cs` |

### ExchangesIdVolumeChart

- **Signature**: `ExchangesIdVolumeChart(Days days, string id = "binance", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `id` = `"binance"`
- **Query params (wire ← C#)**: `days` ← `days`
- **Returns**: `IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Days` | `Models/Enums/Days.cs` |
| `ExchangeVolumeChart` | `Models/AnyOf/ExchangeVolumeChart.cs` |

### ExchangesList

- **Signature**: `ExchangesList(Status? status, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `status` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `status` ← `status`
- **Returns**: `IReadOnlyList<ExchangesList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Status` | `Models/Enums/Status.cs` |
| `ExchangesList` | `Models/ExchangesList.cs` |

### GlobalDefi

- **Signature**: `GlobalDefi(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GlobalDeFi`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GlobalDeFi` | `Models/GlobalDeFi.cs` |

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

### NftsContractAddress

- **Signature**: `NftsContractAddress(string assetPlatformId = "ethereum", string contractAddress = "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `assetPlatformId` = `"ethereum"`, `contractAddress` = `"0xBd3531dA5CF5857e7CfAA92426877b022e612cf8"`
- **Returns**: `NftData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftData` | `Models/NftData.cs` |

### NftsId

- **Signature**: `NftsId(string id = "pudgy-penguins", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `id` = `"pudgy-penguins"`
- **Returns**: `NftData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftData` | `Models/NftData.cs` |

### NftsList

- **Signature**: `NftsList(Order7? order, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `order` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `order` ← `order`, `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<NfTsList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order7` | `Models/Enums/Order7.cs` |
| `NfTsList` | `Models/NfTsList.cs` |

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

### PingServer

- **Signature**: `PingServer(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PingServer`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PingServer` | `Models/PingServer.cs` |

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

### PublicTreasuryEntity

- **Signature**: `PublicTreasuryEntity(string? holdingAmountChange, string? holdingChangePercentage, string entityId = "strategy", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `holdingAmountChange` — nullable, no default → **must pass explicitly**
  - `holdingChangePercentage` — nullable, no default → **must pass explicitly**
  - defaults: `entityId` = `"strategy"`
- **Query params (wire ← C#)**: `holding_amount_change` ← `holdingAmountChange`, `holding_change_percentage` ← `holdingChangePercentage`
- **Returns**: `PublicTreasuryEntity`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryEntity` | `Models/PublicTreasuryEntity.cs` |

### PublicTreasuryEntityChart

- **Signature**: `PublicTreasuryEntityChart(bool? includeEmptyIntervals, string entityId = "strategy", string coinId = "bitcoin", string days = "365", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeEmptyIntervals` — nullable, no default → **must pass explicitly**
  - defaults: `entityId` = `"strategy"`, `coinId` = `"bitcoin"`, `days` = `"365"`
- **Query params (wire ← C#)**: `days` ← `days`, `include_empty_intervals` ← `includeEmptyIntervals`
- **Returns**: `PublicTreasuryEntityChart`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryEntityChart` | `Models/PublicTreasuryEntityChart.cs` |

### PublicTreasuryTransactionHistory

- **Signature**: `PublicTreasuryTransactionHistory(int? perPage, int? page, Order6? order, string? coinIds, string entityId = "strategy", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`perPage` … `coinIds`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `entityId` = `"strategy"`
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`, `order` ← `order`, `coin_ids` ← `coinIds`
- **Returns**: `PublicTreasuryTransactionHistory`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order6` | `Models/Enums/Order6.cs` |
| `PublicTreasuryTransactionHistory` | `Models/PublicTreasuryTransactionHistory.cs` |

### SearchData

- **Signature**: `SearchData(string query, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `query` ← `query`
- **Returns**: `Search`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Search` | `Models/Search.cs` |

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

### SimplePrice

- **Signature**: `SimplePrice(IncludeTokens? includeTokens, bool? includeMarketCap, bool? include24HrVol, bool? include24HrChange, bool? includeLastUpdatedAt, Precision? precision, string vsCurrencies = "usd", string? ids = "bitcoin", string? names = "Bitcoin", string? symbols = "btc", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`includeTokens` … `precision`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `vsCurrencies` = `"usd"`, `ids` = `"bitcoin"`, `names` = `"Bitcoin"`, `symbols` = `"btc"`
- **Query params (wire ← C#)**: `vs_currencies` ← `vsCurrencies`, `ids` ← `ids`, `names` ← `names`, `symbols` ← `symbols`, `include_tokens` ← `includeTokens`, `include_market_cap` ← `includeMarketCap`, `include_24hr_vol` ← `include24HrVol`, `include_24hr_change` ← `include24HrChange`, `include_last_updated_at` ← `includeLastUpdatedAt`, `precision` ← `precision`
- **Returns**: `IReadOnlyDictionary<string, SimplePrice>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncludeTokens` | `Models/Enums/IncludeTokens.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `SimplePrice` | `Models/SimplePrice.cs` |

### SimpleSupportedCurrencies

- **Signature**: `SimpleSupportedCurrencies(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<string>`
- **Error**: `SdkException<RawError>` — **Case B**

### SimpleTokenPrice

- **Signature**: `SimpleTokenPrice(bool? includeMarketCap, bool? include24HrVol, bool? include24HrChange, bool? includeLastUpdatedAt, Precision? precision, string id = "ethereum", string contractAddresses = "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599", string vsCurrencies = "usd", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`includeMarketCap` … `precision`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `id` = `"ethereum"`, `contractAddresses` = `"0x2260fac5e5542a773aa44fbcfedf7c193bc2c599"`, `vsCurrencies` = `"usd"`
- **Query params (wire ← C#)**: `contract_addresses` ← `contractAddresses`, `vs_currencies` ← `vsCurrencies`, `include_market_cap` ← `includeMarketCap`, `include_24hr_vol` ← `include24HrVol`, `include_24hr_change` ← `include24HrChange`, `include_last_updated_at` ← `includeLastUpdatedAt`, `precision` ← `precision`
- **Returns**: `IReadOnlyDictionary<string, SimplePrice>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Precision` | `Models/Enums/Precision.cs` |
| `SimplePrice` | `Models/SimplePrice.cs` |

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

### TokenLists

- **Signature**: `TokenLists(string assetPlatformId = "ethereum", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `assetPlatformId` = `"ethereum"`
- **Returns**: `TokenLists`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenLists` | `Models/TokenLists.cs` |

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

### TrendingSearch

- **Signature**: `TrendingSearch(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TrendingSearch`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingSearch` | `Models/TrendingSearch.cs` |

