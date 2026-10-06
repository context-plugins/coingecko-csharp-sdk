<!-- Generated file — do not edit; regenerated with the SDK. -->

# Entities — operations

Accessor: `client.Entities` · Source: `Api/Entities.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CompaniesPublicTreasury

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `CompaniesPublicTreasury(CompaniesPublicTreasuryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `per_page` ← `PerPage`, `page` ← `Page`, `order` ← `Order`
- **Returns**: `PublicTreasury`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CompaniesPublicTreasuryRequest` | `Requests/Entities/CompaniesPublicTreasuryRequest.cs` |
| `Entity` | `Models/Enums/Entity.cs` |
| `Order5` | `Models/Enums/Order5.cs` |
| `PublicTreasury` | `Models/AnyOf/PublicTreasury.cs` |

### EntitiesList

- **Auth**: `options.HeaderAuth` OR `options.QueryAuth`
- **Signature**: `EntitiesList(EntitiesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `entity_type` ← `EntityType`, `per_page` ← `PerPage`, `page` ← `Page`
- **Returns**: `IReadOnlyList<EntitiesList>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EntitiesListRequest` | `Requests/Entities/EntitiesListRequest.cs` |
| `EntityType` | `Models/Enums/EntityType.cs` |
| `EntitiesList` | `Models/EntitiesList.cs` |

