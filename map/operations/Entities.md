<!-- Generated file — do not edit; regenerated with the SDK. -->

# Entities — operations

Accessor: `client.Entities` · Source: `Api/Entities.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CompaniesPublicTreasury

- **Signature**: `CompaniesPublicTreasury(Entity entity, int? perPage, int? page, Order5? order, string coinId = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `order` — nullable, no default → **must pass explicitly**
  - defaults: `coinId` = `"bitcoin"`
- **Query params (wire ← C#)**: `per_page` ← `perPage`, `page` ← `page`, `order` ← `order`
- **Returns**: `PublicTreasury`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Entity` | `Models/Enums/Entity.cs` |
| `Order5` | `Models/Enums/Order5.cs` |
| `PublicTreasury` | `Models/AnyOf/PublicTreasury.cs` |

### EntitiesList

- **Signature**: `EntitiesList(EntityType? entityType, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `entityType` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `entity_type` ← `entityType`, `per_page` ← `perPage`, `page` ← `page`
- **Returns**: `IReadOnlyList<EntitiesList>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EntityType` | `Models/Enums/EntityType.cs` |
| `EntitiesList` | `Models/EntitiesList.cs` |

