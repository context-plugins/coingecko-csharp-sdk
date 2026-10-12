<!-- Generated file — do not edit; regenerated with the SDK. -->

# Coins — operations

Accessor: `client.Coins` · Source: `src/CoinGecko/Api/Coins.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CoinsCategories

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsCategories(CoinsCategoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`
- **Returns**: `IReadOnlyList<Category1>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsCategoriesRequest` | `src/CoinGecko/Requests/Coins/CoinsCategoriesRequest.cs` |
| `Order2` | `src/CoinGecko/Models/Enums/Order2.cs` |
| `Category1` | `src/CoinGecko/Models/Category1.cs` |

### CoinsCategoriesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsCategoriesList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<CategoriesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CategoriesList` | `src/CoinGecko/Models/CategoriesList.cs` |

### CoinsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsContractAddress(CoinsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CoinsContractAddress`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsContractAddressRequest` | `src/CoinGecko/Requests/Coins/CoinsContractAddressRequest.cs` |
| `CoinsContractAddress` | `src/CoinGecko/Models/CoinsContractAddress.cs` |

### CoinsId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsId(CoinsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `localization` ← `Localization`, `tickers` ← `Tickers`, `market_data` ← `MarketData`, `community_data` ← `CommunityData`, `developer_data` ← `DeveloperData`, `sparkline` ← `Sparkline`, `include_categories_details` ← `IncludeCategoriesDetails`, `dex_pair_format` ← `DexPairFormat`
- **Returns**: `CoinsId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdRequest` | `src/CoinGecko/Requests/Coins/CoinsIdRequest.cs` |
| `DexPairFormat` | `src/CoinGecko/Models/Enums/DexPairFormat.cs` |
| `CoinsId` | `src/CoinGecko/Models/CoinsId.cs` |

### CoinsIdHistory

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdHistory(CoinsIdHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date` ← `Date`, `localization` ← `Localization`
- **Returns**: `CoinsIdHistory`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdHistoryRequest` | `src/CoinGecko/Requests/Coins/CoinsIdHistoryRequest.cs` |
| `CoinsIdHistory` | `src/CoinGecko/Models/CoinsIdHistory.cs` |

### CoinsIdMarketChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdMarketChart(CoinsIdMarketChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `days` ← `Days`, `interval` ← `Interval`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdMarketChartRequest` | `src/CoinGecko/Requests/Coins/CoinsIdMarketChartRequest.cs` |
| `Interval` | `src/CoinGecko/Models/Enums/Interval.cs` |
| `Precision` | `src/CoinGecko/Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `src/CoinGecko/Models/CoinsMarketChart.cs` |

### CoinsIdMarketChartRange

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdMarketChartRange(CoinsIdMarketChartRangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `from` ← `From`, `to` ← `To`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdMarketChartRangeRequest` | `src/CoinGecko/Requests/Coins/CoinsIdMarketChartRangeRequest.cs` |
| `Precision` | `src/CoinGecko/Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `src/CoinGecko/Models/CoinsMarketChart.cs` |

### CoinsIdOhlc

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdOhlc(CoinsIdOhlcRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `days` ← `Days`, `precision` ← `Precision`
- **Returns**: `IReadOnlyList<IReadOnlyList<double>>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdOhlcRequest` | `src/CoinGecko/Requests/Coins/CoinsIdOhlcRequest.cs` |
| `Days` | `src/CoinGecko/Models/Enums/Days.cs` |
| `Precision` | `src/CoinGecko/Models/Enums/Precision.cs` |

### CoinsIdTickers

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsIdTickers(CoinsIdTickersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `exchange_ids` ← `ExchangeIds`, `include_exchange_logo` ← `IncludeExchangeLogo`, `page` ← `Page`, `order` ← `Order`, `depth` ← `Depth`, `dex_pair_format` ← `DexPairFormat`
- **Returns**: `CoinsIdTickers`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsIdTickersRequest` | `src/CoinGecko/Requests/Coins/CoinsIdTickersRequest.cs` |
| `Order1` | `src/CoinGecko/Models/Enums/Order1.cs` |
| `DexPairFormat` | `src/CoinGecko/Models/Enums/DexPairFormat.cs` |
| `CoinsIdTickers` | `src/CoinGecko/Models/CoinsIdTickers.cs` |

### CoinsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsList(CoinsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_platform` ← `IncludePlatform`, `status` ← `Status`
- **Returns**: `IReadOnlyList<CoinsList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsListRequest` | `src/CoinGecko/Requests/Coins/CoinsListRequest.cs` |
| `Status` | `src/CoinGecko/Models/Enums/Status.cs` |
| `CoinsList` | `src/CoinGecko/Models/CoinsList.cs` |

### CoinsMarkets

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CoinsMarkets(CoinsMarketsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `ids` ← `Ids`, `names` ← `Names`, `symbols` ← `Symbols`, `include_tokens` ← `IncludeTokens`, `category` ← `Category`, `order` ← `Order`, `per_page` ← `PerPage`, `page` ← `Page`, `sparkline` ← `Sparkline`, `price_change_percentage` ← `PriceChangePercentage`, `locale` ← `Locale`, `precision` ← `Precision`, `include_rehypothecated` ← `IncludeRehypothecated`
- **Returns**: `IReadOnlyList<CoinsMarket>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CoinsMarketsRequest` | `src/CoinGecko/Requests/Coins/CoinsMarketsRequest.cs` |
| `IncludeTokens` | `src/CoinGecko/Models/Enums/IncludeTokens.cs` |
| `Order` | `src/CoinGecko/Models/Enums/Order.cs` |
| `Locale` | `src/CoinGecko/Models/Enums/Locale.cs` |
| `Precision` | `src/CoinGecko/Models/Enums/Precision.cs` |
| `CoinsMarket` | `src/CoinGecko/Models/CoinsMarket.cs` |

### ContractAddressMarketChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ContractAddressMarketChart(ContractAddressMarketChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `days` ← `Days`, `interval` ← `Interval`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContractAddressMarketChartRequest` | `src/CoinGecko/Requests/Coins/ContractAddressMarketChartRequest.cs` |
| `Interval` | `src/CoinGecko/Models/Enums/Interval.cs` |
| `Precision` | `src/CoinGecko/Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `src/CoinGecko/Models/CoinsMarketChart.cs` |

### ContractAddressMarketChartRange

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ContractAddressMarketChartRange(ContractAddressMarketChartRangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currency` ← `VsCurrency`, `from` ← `From`, `to` ← `To`, `precision` ← `Precision`
- **Returns**: `CoinsMarketChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ContractAddressMarketChartRangeRequest` | `src/CoinGecko/Requests/Coins/ContractAddressMarketChartRangeRequest.cs` |
| `Precision` | `src/CoinGecko/Models/Enums/Precision.cs` |
| `CoinsMarketChart` | `src/CoinGecko/Models/CoinsMarketChart.cs` |

