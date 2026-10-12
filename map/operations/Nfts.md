<!-- Generated file — do not edit; regenerated with the SDK. -->

# Nfts — operations

Accessor: `client.Nfts` · Source: `src/CoinGecko/Api/Nfts.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### NftsContractAddress

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsContractAddress(NftsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NftData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftsContractAddressRequest` | `src/CoinGecko/Requests/Nfts/NftsContractAddressRequest.cs` |
| `NftData` | `src/CoinGecko/Models/NftData.cs` |

### NftsId

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsId(NftsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `NftData`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftsIdRequest` | `src/CoinGecko/Requests/Nfts/NftsIdRequest.cs` |
| `NftData` | `src/CoinGecko/Models/NftData.cs` |

### NftsList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `NftsList(NftsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `order` ← `Order`, `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<NfTsList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `NftsListRequest` | `src/CoinGecko/Requests/Nfts/NftsListRequest.cs` |
| `Order7` | `src/CoinGecko/Models/Enums/Order7.cs` |
| `NfTsList` | `src/CoinGecko/Models/NfTsList.cs` |

