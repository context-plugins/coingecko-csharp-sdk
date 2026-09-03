<!-- Generated file — do not edit; regenerated with the SDK. -->

# Nfts — operations

Accessor: `client.Nfts` · Source: `Api/Nfts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### NftsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsContractAddress(string assetPlatformId = "ethereum", string contractAddress = "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `assetPlatformId` = `"ethereum"`, `contractAddress` = `"0xBd3531dA5CF5857e7CfAA92426877b022e612cf8"`
- **Returns**: `NftData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftData` | `Models/NftData.cs` |

### NftsId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsId(string id = "pudgy-penguins", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - defaults: `id` = `"pudgy-penguins"`
- **Returns**: `NftData`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftData` | `Models/NftData.cs` |

### NftsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsList(Order7? order, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `order` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `order` ← `order`, `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<NfTsList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order7` | `Models/Enums/Order7.cs` |
| `NfTsList` | `Models/NfTsList.cs` |

