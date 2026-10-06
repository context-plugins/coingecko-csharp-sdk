<!-- Generated file — do not edit; regenerated with the SDK. -->

# Misc — operations

Accessor: `client.Misc` · Source: `Api/Misc.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssetPlatformsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `AssetPlatformsList(AssetPlatformsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `filter` ← `Filter`
- **Returns**: `IReadOnlyList<AssetPlatform>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AssetPlatformsListRequest` | `Requests/Misc/AssetPlatformsListRequest.cs` |
| `Filter` | `Models/Enums/Filter.cs` |
| `AssetPlatform` | `Models/AssetPlatform.cs` |

### PingServer

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `PingServer(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PingServer`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PingServer` | `Models/PingServer.cs` |

### TokenLists

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `TokenLists(TokenListsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TokenLists`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenListsRequest` | `Requests/Misc/TokenListsRequest.cs` |
| `TokenLists` | `Models/TokenLists.cs` |

