<!-- Generated file — do not edit; regenerated with the SDK. -->

# Exchanges — operations

Accessor: `client.Exchanges` · Source: `Api/Exchanges.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExchangeRates

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangeRates(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ExchangeRates`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangeRates` | `Models/ExchangeRates.cs` |

### ExchangesId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesId(ExchangesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `dex_pair_format` ← `DexPairFormat`
- **Returns**: `ExchangesId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesIdRequest` | `Requests/Exchanges/ExchangesIdRequest.cs` |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `ExchangesId` | `Models/ExchangesId.cs` |

### ExchangesIdTickers

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesIdTickers(ExchangesIdTickersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `coin_ids` ← `CoinIds`, `include_exchange_logo` ← `IncludeExchangeLogo`, `page` ← `Page`, `depth` ← `Depth`, `order` ← `Order`, `dex_pair_format` ← `DexPairFormat`
- **Returns**: `CoinsIdTickers`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesIdTickersRequest` | `Requests/Exchanges/ExchangesIdTickersRequest.cs` |
| `Order3` | `Models/Enums/Order3.cs` |
| `DexPairFormat` | `Models/Enums/DexPairFormat.cs` |
| `CoinsIdTickers` | `Models/CoinsIdTickers.cs` |

### ExchangesIdVolumeChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesIdVolumeChart(ExchangesIdVolumeChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `days` ← `Days`
- **Returns**: `IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesIdVolumeChartRequest` | `Requests/Exchanges/ExchangesIdVolumeChartRequest.cs` |
| `Days` | `Models/Enums/Days.cs` |
| `ExchangeVolumeChart` | `Models/AnyOf/ExchangeVolumeChart.cs` |

### ExchangesInvoke

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesInvoke(ExchangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<Exchange1>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesRequest` | `Requests/Exchanges/ExchangesRequest.cs` |
| `Exchange1` | `Models/Exchange1.cs` |

### ExchangesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `ExchangesList(ExchangesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `IReadOnlyList<ExchangesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangesListRequest` | `Requests/Exchanges/ExchangesListRequest.cs` |
| `Status` | `Models/Enums/Status.cs` |
| `ExchangesList` | `Models/ExchangesList.cs` |

