<!-- Generated file — do not edit; regenerated with the SDK. -->

# Derivatives — operations

Accessor: `client.Derivatives` · Source: `Api/Derivatives.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

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

