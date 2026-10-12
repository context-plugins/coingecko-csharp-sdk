<!-- Generated file — do not edit; regenerated with the SDK. -->

# Derivatives — operations

Accessor: `client.Derivatives` · Source: `src/CoinGecko/Api/Derivatives.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DerivativesExchanges

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesExchanges(DerivativesExchangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`, `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<DerivativesExchange>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesRequest` | `src/CoinGecko/Requests/Derivatives/DerivativesExchangesRequest.cs` |
| `Order4` | `src/CoinGecko/Models/Enums/Order4.cs` |
| `DerivativesExchange` | `src/CoinGecko/Models/DerivativesExchange.cs` |

### DerivativesExchangesId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesExchangesId(DerivativesExchangesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `include_tickers` ← `IncludeTickers`
- **Returns**: `DerivativesExchangesId`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesIdRequest` | `src/CoinGecko/Requests/Derivatives/DerivativesExchangesIdRequest.cs` |
| `IncludeTickers` | `src/CoinGecko/Models/Enums/IncludeTickers.cs` |
| `DerivativesExchangesId` | `src/CoinGecko/Models/DerivativesExchangesId.cs` |

### DerivativesExchangesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesExchangesList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<DerivativesExchangesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesExchangesList` | `src/CoinGecko/Models/DerivativesExchangesList.cs` |

### DerivativesTickers

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `DerivativesTickers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<DerivativesTicker>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DerivativesTicker` | `src/CoinGecko/Models/DerivativesTicker.cs` |

