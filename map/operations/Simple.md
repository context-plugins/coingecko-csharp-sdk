<!-- Generated file — do not edit; regenerated with the SDK. -->

# Simple — operations

Accessor: `client.Simple` · Source: `Api/Simple.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SimplePrice

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SimplePrice(SimplePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `vs_currencies` ← `VsCurrencies`, `ids` ← `Ids`, `names` ← `Names`, `symbols` ← `Symbols`, `include_tokens` ← `IncludeTokens`, `include_market_cap` ← `IncludeMarketCap`, `include_24hr_vol` ← `Include24HrVol`, `include_24hr_change` ← `Include24HrChange`, `include_last_updated_at` ← `IncludeLastUpdatedAt`, `precision` ← `Precision`
- **Returns**: `IReadOnlyDictionary<string, SimplePrice>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SimplePriceRequest` | `Requests/Simple/SimplePriceRequest.cs` |
| `IncludeTokens` | `Models/Enums/IncludeTokens.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `SimplePrice` | `Models/SimplePrice.cs` |

### SimpleSupportedCurrencies

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SimpleSupportedCurrencies(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<string>`
- **Error**: `ApiException<RawError>` — **Case B**

### SimpleTokenPrice

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SimpleTokenPrice(SimpleTokenPriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `contract_addresses` ← `ContractAddresses`, `vs_currencies` ← `VsCurrencies`, `include_market_cap` ← `IncludeMarketCap`, `include_24hr_vol` ← `Include24HrVol`, `include_24hr_change` ← `Include24HrChange`, `include_last_updated_at` ← `IncludeLastUpdatedAt`, `precision` ← `Precision`
- **Returns**: `IReadOnlyDictionary<string, SimplePrice>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SimpleTokenPriceRequest` | `Requests/Simple/SimpleTokenPriceRequest.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `SimplePrice` | `Models/SimplePrice.cs` |

