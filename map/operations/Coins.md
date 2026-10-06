<!-- Generated file — do not edit; regenerated with the SDK. -->

# Coins — operations

Accessor: `client.Coins` · Source: `Api/Coins.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CoinsCategories

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsCategories(CoinsCategoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`
- **Returns**: `IReadOnlyList<Category1>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsCategoriesRequest` | `Requests/Coins/CoinsCategoriesRequest.cs` |
| `Order2` | `Models/Enums/Order2.cs` |
| `Category1` | `Models/Category1.cs` |

### CoinsCategoriesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsCategoriesList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<CategoriesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesList` | `Models/CategoriesList.cs` |

### CoinsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsContractAddress(CoinsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CoinsContractAddress`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsContractAddressRequest` | `Requests/Coins/CoinsContractAddressRequest.cs` |
| `CoinsContractAddress` | `Models/CoinsContractAddress.cs` |

### CoinsId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsId(CoinsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `localization` ← `Localization`, `tickers` ← `Tickers`, `market_data` ← `MarketData`, `community_data` ← `CommunityData`, `developer_data` ← `DeveloperData`, `sparkline` ← `Sparkline`, `include_categories_details` ← `IncludeCategoriesDetails`, `dex_pair_format` ← `DexPairFormat`
- **Returns**: `CoinsId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdRequest` | `Requests/Coins/CoinsIdRequest.cs` |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `CoinsId` | `Models/CoinsId.cs` |

### CoinsIdHistory

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdHistory(CoinsIdHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date` ← `Date`, `localization` ← `Localization`
- **Returns**: `CoinsIdHistory`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdHistoryRequest` | `Requests/Coins/CoinsIdHistoryRequest.cs` |
| `CoinsIdHistory` | `Models/CoinsIdHistory.cs` |

### CoinsIdMarketChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdMarketChart(CoinsIdMarketChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `days` ← `Days`, `interval` ← `Interval`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdMarketChartRequest` | `Requests/Coins/CoinsIdMarketChartRequest.cs` |
| `Interval` | `Models/Enums/Interval.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### CoinsIdMarketChartRange

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdMarketChartRange(CoinsIdMarketChartRangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `from` ← `From`, `to` ← `To`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdMarketChartRangeRequest` | `Requests/Coins/CoinsIdMarketChartRangeRequest.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### CoinsIdOhlc

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdOhlc(CoinsIdOhlcRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `days` ← `Days`, `precision` ← `Precision`
- **Returns**: `IReadOnlyList<IReadOnlyList<double>>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdOhlcRequest` | `Requests/Coins/CoinsIdOhlcRequest.cs` |
| `Days` | `Models/Enums/Days.cs` |
| `Precision` | `Models/Enums/Precision.cs` |

### CoinsIdTickers

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdTickers(CoinsIdTickersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `exchange_ids` ← `ExchangeIds`, `include_exchange_logo` ← `IncludeExchangeLogo`, `page` ← `Page`, `order` ← `Order`, `depth` ← `Depth`, `dex_pair_format` ← `DexPairFormat`
- **Returns**: `CoinsIdTickers`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdTickersRequest` | `Requests/Coins/CoinsIdTickersRequest.cs` |
| `Order1` | `Models/Enums/Order1.cs` |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `CoinsIdTickers` | `Models/CoinsIdTickers.cs` |

### CoinsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsList(CoinsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_platform` ← `IncludePlatform`, `status` ← `Status`
- **Returns**: `IReadOnlyList<CoinsList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsListRequest` | `Requests/Coins/CoinsListRequest.cs` |
| `Status` | `Models/Enums/Status.cs` |
| `CoinsList` | `Models/CoinsList.cs` |

### CoinsMarkets

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsMarkets(CoinsMarketsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `ids` ← `Ids`, `names` ← `Names`, `symbols` ← `Symbols`, `include_tokens` ← `IncludeTokens`, `category` ← `Category`, `order` ← `Order`, `per_page` ← `PerPage`, `page` ← `Page`, `sparkline` ← `Sparkline`, `price_change_percentage` ← `PriceChangePercentage`, `locale` ← `Locale`, `precision` ← `Precision`, `include_rehypothecated` ← `IncludeRehypothecated`
- **Returns**: `IReadOnlyList<CoinsMarket>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsMarketsRequest` | `Requests/Coins/CoinsMarketsRequest.cs` |
| `IncludeTokens` | `Models/Enums/IncludeTokens.cs` |
| `Order` | `Models/Enums/Order.cs` |
| `Locale` | `Models/Enums/Locale.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarket` | `Models/CoinsMarket.cs` |

### ContractAddressMarketChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ContractAddressMarketChart(ContractAddressMarketChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `days` ← `Days`, `interval` ← `Interval`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContractAddressMarketChartRequest` | `Requests/Coins/ContractAddressMarketChartRequest.cs` |
| `Interval` | `Models/Enums/Interval.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

### ContractAddressMarketChartRange

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ContractAddressMarketChartRange(ContractAddressMarketChartRangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `from` ← `From`, `to` ← `To`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContractAddressMarketChartRangeRequest` | `Requests/Coins/ContractAddressMarketChartRangeRequest.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `Models/CoinsMarketChart.cs` |

