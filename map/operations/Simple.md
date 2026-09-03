<!-- Generated file — do not edit; regenerated with the SDK. -->

# Simple — operations

Accessor: `client.Simple` · Source: `Api/Simple.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SimplePrice

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SimplePrice(IncludeTokens? includeTokens, bool? includeMarketCap, bool? include24HrVol, bool? include24HrChange, bool? includeLastUpdatedAt, Precision? precision, string vsCurrencies = "usd", string? ids = "bitcoin", string? names = "Bitcoin", string? symbols = "btc", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`includeTokens` … `precision`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `vsCurrencies` = `"usd"`, `ids` = `"bitcoin"`, `names` = `"Bitcoin"`, `symbols` = `"btc"`
- **Query params (wire ← C#)**: `vs_currencies` ← `vsCurrencies`, `ids` ← `ids`, `names` ← `names`, `symbols` ← `symbols`, `include_tokens` ← `includeTokens`, `include_market_cap` ← `includeMarketCap`, `include_24hr_vol` ← `include24HrVol`, `include_24hr_change` ← `include24HrChange`, `include_last_updated_at` ← `includeLastUpdatedAt`, `precision` ← `precision`
- **Returns**: `IReadOnlyDictionary<string, SimplePrice>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `IncludeTokens` | `Models/Enums/IncludeTokens.cs` |
| `Precision` | `Models/Enums/Precision.cs` |
| `SimplePrice` | `Models/SimplePrice.cs` |

### SimpleSupportedCurrencies

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SimpleSupportedCurrencies(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<string>`
- **Error**: `SdkException<RawError>` — **Case B**

### SimpleTokenPrice

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SimpleTokenPrice(bool? includeMarketCap, bool? include24HrVol, bool? include24HrChange, bool? includeLastUpdatedAt, Precision? precision, string id = "ethereum", string contractAddresses = "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599", string vsCurrencies = "usd", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`includeMarketCap` … `precision`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `id` = `"ethereum"`, `contractAddresses` = `"0x2260fac5e5542a773aa44fbcfedf7c193bc2c599"`, `vsCurrencies` = `"usd"`
- **Query params (wire ← C#)**: `contract_addresses` ← `contractAddresses`, `vs_currencies` ← `vsCurrencies`, `include_market_cap` ← `includeMarketCap`, `include_24hr_vol` ← `include24HrVol`, `include_24hr_change` ← `include24HrChange`, `include_last_updated_at` ← `includeLastUpdatedAt`, `precision` ← `precision`
- **Returns**: `IReadOnlyDictionary<string, SimplePrice>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Precision` | `Models/Enums/Precision.cs` |
| `SimplePrice` | `Models/SimplePrice.cs` |

