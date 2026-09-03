<!-- Generated file — do not edit; regenerated with the SDK. -->

# PublicTreasuryApi — operations

Accessor: `client.PublicTreasuryApi` · Source: `Api/PublicTreasuryApi.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PublicTreasuryEntity

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PublicTreasuryEntity(string? holdingAmountChange, string? holdingChangePercentage, string entityId = "strategy", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `holdingAmountChange` — nullable, no default → **must pass explicitly**
  - `holdingChangePercentage` — nullable, no default → **must pass explicitly**
  - defaults: `entityId` = `"strategy"`
- **Query params (wire ← C#)**: `holding_amount_change` ← `holdingAmountChange`, `holding_change_percentage` ← `holdingChangePercentage`
- **Returns**: `PublicTreasuryEntity`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryEntity` | `Models/PublicTreasuryEntity.cs` |

### PublicTreasuryEntityChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PublicTreasuryEntityChart(bool? includeEmptyIntervals, string entityId = "strategy", string coinId = "bitcoin", string days = "365", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `includeEmptyIntervals` — nullable, no default → **must pass explicitly**
  - defaults: `entityId` = `"strategy"`, `coinId` = `"bitcoin"`, `days` = `"365"`
- **Query params (wire ← C#)**: `days` ← `days`, `include_empty_intervals` ← `includeEmptyIntervals`
- **Returns**: `PublicTreasuryEntityChart`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryEntityChart` | `Models/PublicTreasuryEntityChart.cs` |

### PublicTreasuryTransactionHistory

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PublicTreasuryTransactionHistory(int? perPage, int? page, Order6? order, string? coinIds, string entityId = "strategy", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`perPage` … `coinIds`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
  - defaults: `entityId` = `"strategy"`
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`, `order` ← `order`, `coin_ids` ← `coinIds`
- **Returns**: `PublicTreasuryTransactionHistory`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order6` | `Models/Enums/Order6.cs` |
| `PublicTreasuryTransactionHistory` | `Models/PublicTreasuryTransactionHistory.cs` |

