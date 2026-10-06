<!-- Generated file — do not edit; regenerated with the SDK. -->

# PublicTreasuryApi — operations

Accessor: `client.PublicTreasuryApi` · Source: `Api/PublicTreasuryApi.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PublicTreasuryEntity

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PublicTreasuryEntity(PublicTreasuryEntityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `holding_amount_change` ← `HoldingAmountChange`, `holding_change_percentage` ← `HoldingChangePercentage`
- **Returns**: `PublicTreasuryEntity`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryEntityRequest` | `Requests/PublicTreasuryApi/PublicTreasuryEntityRequest.cs` |
| `PublicTreasuryEntity` | `Models/PublicTreasuryEntity.cs` |

### PublicTreasuryEntityChart

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PublicTreasuryEntityChart(PublicTreasuryEntityChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `days` ← `Days`, `include_empty_intervals` ← `IncludeEmptyIntervals`
- **Returns**: `PublicTreasuryEntityChart`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryEntityChartRequest` | `Requests/PublicTreasuryApi/PublicTreasuryEntityChartRequest.cs` |
| `PublicTreasuryEntityChart` | `Models/PublicTreasuryEntityChart.cs` |

### PublicTreasuryTransactionHistory

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PublicTreasuryTransactionHistory(PublicTreasuryTransactionHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `per_page` ← `PerPage`, `page` ← `Page`, `order` ← `Order`, `coin_ids` ← `CoinIds`
- **Returns**: `PublicTreasuryTransactionHistory`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PublicTreasuryTransactionHistoryRequest` | `Requests/PublicTreasuryApi/PublicTreasuryTransactionHistoryRequest.cs` |
| `Order6` | `Models/Enums/Order6.cs` |
| `PublicTreasuryTransactionHistory` | `Models/PublicTreasuryTransactionHistory.cs` |

