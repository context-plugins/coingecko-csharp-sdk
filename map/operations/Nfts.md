<!-- Generated file — do not edit; regenerated with the SDK. -->

# Nfts — operations

Accessor: `client.Nfts` · Source: `Api/Nfts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### NftsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsContractAddress(NftsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NftData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftsContractAddressRequest` | `Requests/Nfts/NftsContractAddressRequest.cs` |
| `NftData` | `Models/NftData.cs` |

### NftsId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsId(NftsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NftData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftsIdRequest` | `Requests/Nfts/NftsIdRequest.cs` |
| `NftData` | `Models/NftData.cs` |

### NftsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsList(NftsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`, `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<NfTsList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftsListRequest` | `Requests/Nfts/NftsListRequest.cs` |
| `Order7` | `Models/Enums/Order7.cs` |
| `NfTsList` | `Models/NfTsList.cs` |

