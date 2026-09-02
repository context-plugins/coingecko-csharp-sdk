<!-- Generated file — do not edit; regenerated with the SDK. -->

# Coins — operations

Accessor: `client.Coins` · Source: `Api/Coins.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

