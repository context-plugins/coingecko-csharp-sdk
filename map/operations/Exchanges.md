<!-- Generated file — do not edit; regenerated with the SDK. -->

# Exchanges — operations

Accessor: `client.Exchanges` · Source: `src/CoinGecko/Api/Exchanges.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExchangeRates

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangeRates(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ExchangeRates`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangeRates` | `src/CoinGecko/Models/ExchangeRates.cs` |

### ExchangesId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesId(ExchangesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `dex_pair_format` ← `DexPairFormat`
- **Returns**: `ExchangesId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesIdRequest` | `src/CoinGecko/Requests/Exchanges/ExchangesIdRequest.cs` |
| `DexPairFormat` | `src/CoinGecko/Models/Enums/DexPairFormat.cs` |
| `ExchangesId` | `src/CoinGecko/Models/ExchangesId.cs` |

### ExchangesIdTickers

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesIdTickers(ExchangesIdTickersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `coin_ids` ← `CoinIds`, `include_exchange_logo` ← `IncludeExchangeLogo`, `page` ← `Page`, `depth` ← `Depth`, `order` ← `Order`, `dex_pair_format` ← `DexPairFormat`
- **Returns**: `CoinsIdTickers`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesIdTickersRequest` | `src/CoinGecko/Requests/Exchanges/ExchangesIdTickersRequest.cs` |
| `Order3` | `src/CoinGecko/Models/Enums/Order3.cs` |
| `DexPairFormat` | `src/CoinGecko/Models/Enums/DexPairFormat.cs` |
| `CoinsIdTickers` | `src/CoinGecko/Models/CoinsIdTickers.cs` |

### ExchangesIdVolumeChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesIdVolumeChart(ExchangesIdVolumeChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `days` ← `Days`
- **Returns**: `IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesIdVolumeChartRequest` | `src/CoinGecko/Requests/Exchanges/ExchangesIdVolumeChartRequest.cs` |
| `Days` | `src/CoinGecko/Models/Enums/Days.cs` |
| `ExchangeVolumeChart` | `src/CoinGecko/Models/AnyOf/ExchangeVolumeChart.cs` |

### ExchangesInvoke

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesInvoke(ExchangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<Exchange1>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesRequest` | `src/CoinGecko/Requests/Exchanges/ExchangesRequest.cs` |
| `Exchange1` | `src/CoinGecko/Models/Exchange1.cs` |

### ExchangesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesList(ExchangesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `IReadOnlyList<ExchangesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesListRequest` | `src/CoinGecko/Requests/Exchanges/ExchangesListRequest.cs` |
| `Status` | `src/CoinGecko/Models/Enums/Status.cs` |
| `ExchangesList` | `src/CoinGecko/Models/ExchangesList.cs` |

