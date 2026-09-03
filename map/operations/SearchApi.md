<!-- Generated file — do not edit; regenerated with the SDK. -->

# SearchApi — operations

Accessor: `client.SearchApi` · Source: `Api/SearchApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SearchData

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SearchData(string query, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `query` ← `query`
- **Returns**: `Search`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Search` | `Models/Search.cs` |

### TrendingSearch

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TrendingSearch(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TrendingSearch`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingSearch` | `Models/TrendingSearch.cs` |

