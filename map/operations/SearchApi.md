<!-- Generated file — do not edit; regenerated with the SDK. -->

# SearchApi — operations

Accessor: `client.SearchApi` · Source: `Api/SearchApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SearchData

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `SearchData(SearchDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Query`
- **Query params (wire ← C#)**: `query` ← `Query`
- **Returns**: `Search`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchDataRequest` | `Requests/SearchApi/SearchDataRequest.cs` |
| `Search` | `Models/Search.cs` |

### TrendingSearch

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TrendingSearch(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TrendingSearch`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TrendingSearch` | `Models/TrendingSearch.cs` |

