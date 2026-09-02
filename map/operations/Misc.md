<!-- Generated file — do not edit; regenerated with the SDK. -->

# Misc — operations

Accessor: `client.Misc` · Source: `Api/Misc.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AssetPlatformsList

- **Signature**: `AssetPlatformsList(Filter? filter, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filter` ← `filter`
- **Returns**: `IReadOnlyList<AssetPlatform>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Filter` | `Models/Enums/Filter.cs` |
| `AssetPlatform` | `Models/AssetPlatform.cs` |

### PingServer

- **Signature**: `PingServer(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `PingServer`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PingServer` | `Models/PingServer.cs` |

### TokenLists

- **Signature**: `TokenLists(string assetPlatformId = "ethereum", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `assetPlatformId` = `"ethereum"`
- **Returns**: `TokenLists`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TokenLists` | `Models/TokenLists.cs` |

