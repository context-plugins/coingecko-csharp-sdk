<!-- Generated file — do not edit; regenerated with the SDK. -->

# Exchanges — operations

Accessor: `client.Exchanges` · Source: `Api/Exchanges.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExchangeRates

- **Signature**: `ExchangeRates(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ExchangeRates`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ExchangeRates` | `Models/ExchangeRates.cs` |

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

### ExchangesInvoke

- **Signature**: `ExchangesInvoke(double? perPage, double? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<Exchange1>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Exchange1` | `Models/Exchange1.cs` |

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

