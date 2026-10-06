<!-- Generated file — do not edit; regenerated with the SDK. -->

# Derivatives — operations

Accessor: `client.Derivatives` · Source: `Api/Derivatives.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DerivativesExchanges

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesExchanges(DerivativesExchangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`, `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<DerivativesExchange>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesRequest` | `Requests/Derivatives/DerivativesExchangesRequest.cs` |
| `Order4` | `Models/Enums/Order4.cs` |
| `DerivativesExchange` | `Models/DerivativesExchange.cs` |

### DerivativesExchangesId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesExchangesId(DerivativesExchangesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_tickers` ← `IncludeTickers`
- **Returns**: `DerivativesExchangesId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesIdRequest` | `Requests/Derivatives/DerivativesExchangesIdRequest.cs` |
| `IncludeTickers` | `Models/Enums/IncludeTickers.cs` |
| `DerivativesExchangesId` | `Models/DerivativesExchangesId.cs` |

### DerivativesExchangesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesExchangesList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<DerivativesExchangesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesList` | `Models/DerivativesExchangesList.cs` |

### DerivativesTickers

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesTickers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<DerivativesTicker>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesTicker` | `Models/DerivativesTicker.cs` |

