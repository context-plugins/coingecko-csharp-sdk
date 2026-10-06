# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [CoinGeckoClient](CoinGeckoClient.cs)

## Coins

> Source: [Coins](Api/Coins.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Category1&gt;&gt; CoinsCategories(CoinsCategoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the coins categories with market data (market cap, volume, etc.) on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsCategories(new CoinsCategoriesRequest());
    // TODO: Handle 'response' of type IReadOnlyList<Category1>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsCategoriesRequest](Requests/Coins/CoinsCategoriesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Category1](Models/Category1.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CategoriesList&gt;&gt; CoinsCategoriesList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported coins categories on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsCategoriesList();
    // TODO: Handle 'response' of type IReadOnlyList<CategoriesList>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CategoriesList](Models/CategoriesList.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsContractAddress&gt; CoinsContractAddress(CoinsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the metadata (image, websites, socials, description, contract address, etc.) and market data (price, ATH, exchange tickers, etc.) of a coin based on an asset platform and a particular token contract address

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsContractAddress(new CoinsContractAddressRequest
    {
        Id = "some example string",
        ContractAddress = "some example string",
    });
    // TODO: Handle 'response' of type CoinsContractAddress
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsContractAddressRequest](Requests/Coins/CoinsContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsContractAddress](Models/CoinsContractAddress.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsId&gt; CoinsId(CoinsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the metadata (image, websites, socials, description, contract address, etc.) and market data (price, ATH, exchange tickers, etc.) of a coin based on a particular coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsId(new CoinsIdRequest { Id = "bitcoin" });
    // TODO: Handle 'response' of type CoinsId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsIdRequest](Requests/Coins/CoinsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsId](Models/CoinsId.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsIdHistory&gt; CoinsIdHistory(CoinsIdHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the historical data (price, market cap, 24hrs volume, etc.) at a given date for a coin based on a particular coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsIdHistory(new CoinsIdHistoryRequest
    {
        Id = "some example string",
        Date = "some example string",
    });
    // TODO: Handle 'response' of type CoinsIdHistory
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsIdHistoryRequest](Requests/Coins/CoinsIdHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsIdHistory](Models/CoinsIdHistory.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; CoinsIdMarketChart(CoinsIdMarketChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get the historical chart data of a coin including time in UNIX, price, market cap and 24hrs volume based on particular coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsIdMarketChart(new CoinsIdMarketChartRequest
    {
        Id = "some example string",
        VsCurrency = "some example string",
        Days = "some example string",
    });
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsIdMarketChartRequest](Requests/Coins/CoinsIdMarketChartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; CoinsIdMarketChartRange(CoinsIdMarketChartRangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get the historical chart data of a coin within certain time range in UNIX along with price, market cap and 24hrs volume based on particular coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsIdMarketChartRange(new CoinsIdMarketChartRangeRequest
    {
        Id = "some example string",
        VsCurrency = "some example string",
        From = 1,
        To = 1,
    });
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsIdMarketChartRangeRequest](Requests/Coins/CoinsIdMarketChartRangeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;double&gt;&gt;&gt; CoinsIdOhlc(CoinsIdOhlcRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get the OHLC chart (Open, High, Low, Close) of a coin based on particular coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsIdOhlc(new CoinsIdOhlcRequest
    {
        Id = "some example string",
        VsCurrency = "some example string",
        Days = Days._1,
    });
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<double>>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsIdOhlcRequest](Requests/Coins/CoinsIdOhlcRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;double&gt;&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsIdTickers&gt; CoinsIdTickers(CoinsIdTickersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the coin tickers on both centralized exchange (CEX) and decentralized exchange (DEX) based on a particular coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsIdTickers(new CoinsIdTickersRequest { Id = "some example string" });
    // TODO: Handle 'response' of type CoinsIdTickers
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsIdTickersRequest](Requests/Coins/CoinsIdTickersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsIdTickers](Models/CoinsIdTickers.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CoinsList&gt;&gt; CoinsList(CoinsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported coins on CoinGecko with coin ID, name and symbol

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsList(new CoinsListRequest());
    // TODO: Handle 'response' of type IReadOnlyList<CoinsList>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsListRequest](Requests/Coins/CoinsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CoinsList](Models/CoinsList.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CoinsMarket&gt;&gt; CoinsMarkets(CoinsMarketsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported coins with price, market cap, volume and market related data

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.CoinsMarkets(new CoinsMarketsRequest { VsCurrency = "some example string" });
    // TODO: Handle 'response' of type IReadOnlyList<CoinsMarket>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CoinsMarketsRequest](Requests/Coins/CoinsMarketsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CoinsMarket](Models/CoinsMarket.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; ContractAddressMarketChart(ContractAddressMarketChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get the historical chart data including time in UNIX, price, market cap and 24hrs volume based on asset platform and particular token contract address

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.ContractAddressMarketChart(new ContractAddressMarketChartRequest
    {
        Id = "some example string",
        ContractAddress = "some example string",
        VsCurrency = "some example string",
        Days = "some example string",
    });
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ContractAddressMarketChartRequest](Requests/Coins/ContractAddressMarketChartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; ContractAddressMarketChartRange(ContractAddressMarketChartRangeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get the historical chart data within certain time range in UNIX along with price, market cap and 24hrs volume based on asset platform and particular token contract address

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Coins.ContractAddressMarketChartRange(new ContractAddressMarketChartRangeRequest
    {
        Id = "some example string",
        ContractAddress = "some example string",
        VsCurrency = "some example string",
        From = 1,
        To = 1,
    });
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ContractAddressMarketChartRangeRequest](Requests/Coins/ContractAddressMarketChartRangeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Derivatives

> Source: [Derivatives](Api/Derivatives.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DerivativesExchange&gt;&gt; DerivativesExchanges(DerivativesExchangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the derivatives exchanges with related data (ID, name, open interest, ...) on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Derivatives.DerivativesExchanges(new DerivativesExchangesRequest());
    // TODO: Handle 'response' of type IReadOnlyList<DerivativesExchange>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DerivativesExchangesRequest](Requests/Derivatives/DerivativesExchangesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DerivativesExchange](Models/DerivativesExchange.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DerivativesExchangesId&gt; DerivativesExchangesId(DerivativesExchangesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the derivatives exchange's related data (name, open interest, trade volume, ...) based on the exchange's ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Derivatives.DerivativesExchangesId(new DerivativesExchangesIdRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type DerivativesExchangesId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DerivativesExchangesIdRequest](Requests/Derivatives/DerivativesExchangesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DerivativesExchangesId](Models/DerivativesExchangesId.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DerivativesExchangesList&gt;&gt; DerivativesExchangesList(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported derivatives exchanges with ID and name on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Derivatives.DerivativesExchangesList();
    // TODO: Handle 'response' of type IReadOnlyList<DerivativesExchangesList>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DerivativesExchangesList](Models/DerivativesExchangesList.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DerivativesTicker&gt;&gt; DerivativesTickers(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the tickers from derivatives exchanges on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Derivatives.DerivativesTickers();
    // TODO: Handle 'response' of type IReadOnlyList<DerivativesTicker>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DerivativesTicker](Models/DerivativesTicker.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Entities

> Source: [Entities](Api/Entities.cs)

<details>
<summary><code>Task&lt;PublicTreasury&gt; CompaniesPublicTreasury(CompaniesPublicTreasuryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query public companies' and governments' cryptocurrency holdings by coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.CompaniesPublicTreasury(new CompaniesPublicTreasuryRequest
    {
        Entity = Entity.Companies,
        CoinId = "some example string",
    });
    // TODO: Handle 'response' of type PublicTreasury
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CompaniesPublicTreasuryRequest](Requests/Entities/CompaniesPublicTreasuryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasury](Models/AnyOf/PublicTreasury.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;EntitiesList&gt;&gt; EntitiesList(EntitiesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported entities on CoinGecko with entity ID, name, symbol, and country

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Entities.EntitiesList(new EntitiesListRequest());
    // TODO: Handle 'response' of type IReadOnlyList<EntitiesList>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[EntitiesListRequest](Requests/Entities/EntitiesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[EntitiesList](Models/EntitiesList.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Exchanges

> Source: [Exchanges](Api/Exchanges.cs)

<details>
<summary><code>Task&lt;ExchangeRates&gt; ExchangeRates(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query BTC exchange rates with other currencies

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exchanges.ExchangeRates();
    // TODO: Handle 'response' of type ExchangeRates
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExchangeRates](Models/ExchangeRates.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Exchange1&gt;&gt; ExchangesInvoke(ExchangesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported exchanges with exchanges' data (ID, name, country, etc.) that have active trading volumes on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exchanges.ExchangesInvoke(new ExchangesRequest());
    // TODO: Handle 'response' of type IReadOnlyList<Exchange1>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExchangesRequest](Requests/Exchanges/ExchangesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Exchange1](Models/Exchange1.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ExchangesId&gt; ExchangesId(ExchangesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query exchange's data (name, year established, country, etc.), exchange volume in BTC and top 100 tickers based on exchange's ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exchanges.ExchangesId(new ExchangesIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type ExchangesId
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExchangesIdRequest](Requests/Exchanges/ExchangesIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExchangesId](Models/ExchangesId.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsIdTickers&gt; ExchangesIdTickers(ExchangesIdTickersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query exchange's tickers based on exchange's ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exchanges.ExchangesIdTickers(new ExchangesIdTickersRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type CoinsIdTickers
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExchangesIdTickersRequest](Requests/Exchanges/ExchangesIdTickersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsIdTickers](Models/CoinsIdTickers.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;ExchangeVolumeChart&gt;&gt;&gt; ExchangesIdVolumeChart(ExchangesIdVolumeChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the historical volume chart data with time in UNIX and trading volume data in BTC based on exchange's ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exchanges.ExchangesIdVolumeChart(new ExchangesIdVolumeChartRequest
    {
        Id = "some example string",
        Days = Days._1,
    });
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExchangesIdVolumeChartRequest](Requests/Exchanges/ExchangesIdVolumeChartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ExchangeVolumeChart](Models/AnyOf/ExchangeVolumeChart.cs)&gt;&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ExchangesList&gt;&gt; ExchangesList(ExchangesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported exchanges with ID and name

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Exchanges.ExchangesList(new ExchangesListRequest());
    // TODO: Handle 'response' of type IReadOnlyList<ExchangesList>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ExchangesListRequest](Requests/Exchanges/ExchangesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ExchangesList](Models/ExchangesList.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## GlobalApi

> Source: [GlobalApi](Api/GlobalApi.cs)

<details>
<summary><code>Task&lt;Global&gt; CryptoGlobal(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query cryptocurrency global data including active cryptocurrencies, markets, total crypto market cap and etc

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GlobalApi.CryptoGlobal();
    // TODO: Handle 'response' of type Global
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Global](Models/Global.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GlobalDeFi&gt; GlobalDefi(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query top 100 cryptocurrency global decentralized finance (DeFi) data including DeFi market cap, trading volume

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.GlobalApi.GlobalDefi();
    // TODO: Handle 'response' of type GlobalDeFi
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[GlobalDeFi](Models/GlobalDeFi.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Misc

> Source: [Misc](Api/Misc.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AssetPlatform&gt;&gt; AssetPlatformsList(AssetPlatformsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported asset platforms (blockchain networks) on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Misc.AssetPlatformsList(new AssetPlatformsListRequest());
    // TODO: Handle 'response' of type IReadOnlyList<AssetPlatform>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AssetPlatformsListRequest](Requests/Misc/AssetPlatformsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AssetPlatform](Models/AssetPlatform.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PingServer&gt; PingServer(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To check the API server status

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Misc.PingServer();
    // TODO: Handle 'response' of type PingServer
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PingServer](Models/PingServer.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenLists&gt; TokenLists(TokenListsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get full list of tokens of a blockchain network (asset platform) that is supported by [Ethereum token list standard](https://tokenlists.org/)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Misc.TokenLists(new TokenListsRequest { AssetPlatformId = "some example string" });
    // TODO: Handle 'response' of type TokenLists
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TokenListsRequest](Requests/Misc/TokenListsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenLists](Models/TokenLists.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Nfts

> Source: [Nfts](Api/Nfts.cs)

<details>
<summary><code>Task&lt;NftData&gt; NftsContractAddress(NftsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the NFT data (name, floor price, 24hr volume, ...) based on the NFT collection contract address and respective asset platform

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nfts.NftsContractAddress(new NftsContractAddressRequest
    {
        AssetPlatformId = "some example string",
        ContractAddress = "some example string",
    });
    // TODO: Handle 'response' of type NftData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NftsContractAddressRequest](Requests/Nfts/NftsContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NftData](Models/NftData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NftData&gt; NftsId(NftsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the NFT data (name, floor price, 24hr volume, ...) based on the NFT collection ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nfts.NftsId(new NftsIdRequest { Id = "some example string" });
    // TODO: Handle 'response' of type NftData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NftsIdRequest](Requests/Nfts/NftsIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NftData](Models/NftData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;NfTsList&gt;&gt; NftsList(NftsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all supported NFTs with ID, contract address, name, asset platform ID and symbol on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Nfts.NftsList(new NftsListRequest());
    // TODO: Handle 'response' of type IReadOnlyList<NfTsList>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NftsListRequest](Requests/Nfts/NftsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[NfTsList](Models/NfTsList.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Onchain

> Source: [Onchain](Api/Onchain.cs)

<details>
<summary><code>Task&lt;DexesList&gt; DexesList(DexesListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported decentralized exchanges (DEXs) based on the provided network on GeckoTerminal

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.DexesList(new DexesListRequest { Network = "some example string" });
    // TODO: Handle 'response' of type DexesList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DexesListRequest](Requests/Onchain/DexesListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DexesList](Models/DexesList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; LatestPoolsList(LatestPoolsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the latest pools across all networks on GeckoTerminal

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.LatestPoolsList(new LatestPoolsListRequest());
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LatestPoolsListRequest](Requests/Onchain/LatestPoolsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; LatestPoolsNetwork(LatestPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the latest pools based on the provided network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.LatestPoolsNetwork(new LatestPoolsNetworkRequest
    {
        Network = "some example string",
    });
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[LatestPoolsNetworkRequest](Requests/Onchain/LatestPoolsNetworkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworksList&gt; NetworksList(NetworksListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To retrieve a list of all supported networks on GeckoTerminal

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.NetworksList(new NetworksListRequest());
    // TODO: Handle 'response' of type NetworksList
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[NetworksListRequest](Requests/Onchain/NetworksListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworksList](Models/NetworksList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnchainSimplePrice&gt; OnchainSimplePrice(OnchainSimplePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get token price based on the provided token contract address on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.OnchainSimplePrice(new OnchainSimplePriceRequest
    {
        Network = "some example string",
        Addresses = "some example string",
    });
    // TODO: Handle 'response' of type OnchainSimplePrice
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[OnchainSimplePriceRequest](Requests/Onchain/OnchainSimplePriceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnchainSimplePrice](Models/OnchainSimplePrice.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PoolAddressData&gt; PoolAddress(PoolAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the specific pool based on the provided network and pool address

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.PoolAddress(new PoolAddressRequest
    {
        Network = "some example string",
        Address = "some example string",
    });
    // TODO: Handle 'response' of type PoolAddressData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PoolAddressRequest](Requests/Onchain/PoolAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PoolAddressData](Models/PoolAddressData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Ohlcv&gt; PoolOhlcvContractAddress(PoolOhlcvContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To get the OHLCV chart (Open, High, Low, Close, Volume) of a pool based on the provided pool address on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.PoolOhlcvContractAddress(new PoolOhlcvContractAddressRequest
    {
        Network = "some example string",
        PoolAddress = "some example string",
        Timeframe = Timeframe.Day,
    });
    // TODO: Handle 'response' of type Ohlcv
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PoolOhlcvContractAddressRequest](Requests/Onchain/PoolOhlcvContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Ohlcv](Models/Ohlcv.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PoolTokensInfo&gt; PoolTokenInfoContractAddress(PoolTokenInfoContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query pool metadata (base and quote token details, image, socials, websites, description, contract address, etc.) based on a provided pool contract address on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.PoolTokenInfoContractAddress(new PoolTokenInfoContractAddressRequest
    {
        Network = "some example string",
        PoolAddress = "some example string",
    });
    // TODO: Handle 'response' of type PoolTokensInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PoolTokenInfoContractAddressRequest](Requests/Onchain/PoolTokenInfoContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PoolTokensInfo](Models/PoolTokensInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Trades&gt; PoolTradesContractAddress(PoolTradesContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the last 300 trades in the past 24 hours based on the provided pool address

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.PoolTradesContractAddress(new PoolTradesContractAddressRequest
    {
        Network = "some example string",
        PoolAddress = "some example string",
    });
    // TODO: Handle 'response' of type Trades
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PoolTradesContractAddressRequest](Requests/Onchain/PoolTradesContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Trades](Models/Trades.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MultiPoolAddressData&gt; PoolsAddresses(PoolsAddressesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query multiple pools based on the provided network and pool addresses

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.PoolsAddresses(new PoolsAddressesRequest
    {
        Network = "some example string",
        Addresses = "some example string",
    });
    // TODO: Handle 'response' of type MultiPoolAddressData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PoolsAddressesRequest](Requests/Onchain/PoolsAddressesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MultiPoolAddressData](Models/MultiPoolAddressData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PoolSearch&gt; SearchPools(SearchPoolsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To search for pools across all networks by pool address, token name, token symbol, or token contract address

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.SearchPools(new SearchPoolsRequest());
    // TODO: Handle 'response' of type PoolSearch
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchPoolsRequest](Requests/Onchain/SearchPoolsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PoolSearch](Models/PoolSearch.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenData&gt; TokenDataContractAddress(TokenDataContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query specific token data based on the provided token contract address on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TokenDataContractAddress(new TokenDataContractAddressRequest
    {
        Network = "some example string",
        Address = "some example string",
    });
    // TODO: Handle 'response' of type TokenData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TokenDataContractAddressRequest](Requests/Onchain/TokenDataContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenData](Models/TokenData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenInfo&gt; TokenInfoContractAddress(TokenInfoContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query token metadata (name, symbol, CoinGecko ID, image, socials, websites, description, etc.) based on a provided token contract address on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TokenInfoContractAddress(new TokenInfoContractAddressRequest
    {
        Network = "some example string",
        Address = "some example string",
    });
    // TODO: Handle 'response' of type TokenInfo
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TokenInfoContractAddressRequest](Requests/Onchain/TokenInfoContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenInfo](Models/TokenInfo.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MultiTokenData&gt; TokensDataContractAddresses(TokensDataContractAddressesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query multiple tokens data based on the provided token contract addresses on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TokensDataContractAddresses(new TokensDataContractAddressesRequest
    {
        Network = "some example string",
        Addresses = "some example string",
    });
    // TODO: Handle 'response' of type MultiTokenData
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TokensDataContractAddressesRequest](Requests/Onchain/TokensDataContractAddressesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MultiTokenData](Models/MultiTokenData.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenInfoRecentlyUpdated&gt; TokensInfoRecentUpdated(TokensInfoRecentUpdatedRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query 100 most recently updated tokens info of a specific network or across all networks on GeckoTerminal

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TokensInfoRecentUpdated(new TokensInfoRecentUpdatedRequest());
    // TODO: Handle 'response' of type TokenInfoRecentlyUpdated
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TokensInfoRecentUpdatedRequest](Requests/Onchain/TokensInfoRecentUpdatedRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenInfoRecentlyUpdated](Models/TokenInfoRecentlyUpdated.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TopPoolsContractAddress(TopPoolsContractAddressRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query top pools based on the provided token contract address on a network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TopPoolsContractAddress(new TopPoolsContractAddressRequest
    {
        Network = "some example string",
        TokenAddress = "some example string",
    });
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TopPoolsContractAddressRequest](Requests/Onchain/TopPoolsContractAddressRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TopPoolsDex(TopPoolsDexRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the top pools based on the provided network and decentralized exchange (DEX)

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TopPoolsDex(new TopPoolsDexRequest
    {
        Network = "some example string",
        Dex = "some example string",
    });
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TopPoolsDexRequest](Requests/Onchain/TopPoolsDexRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TopPoolsNetwork(TopPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the top pools based on the provided network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TopPoolsNetwork(new TopPoolsNetworkRequest { Network = "some example string" });
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TopPoolsNetworkRequest](Requests/Onchain/TopPoolsNetworkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TrendingPoolsList(TrendingPoolsListRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the trending pools across all networks on GeckoTerminal

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TrendingPoolsList(new TrendingPoolsListRequest());
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TrendingPoolsListRequest](Requests/Onchain/TrendingPoolsListRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TrendingPoolsNetwork(TrendingPoolsNetworkRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the trending pools based on the provided network

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Onchain.TrendingPoolsNetwork(new TrendingPoolsNetworkRequest
    {
        Network = "some example string",
    });
    // TODO: Handle 'response' of type Pool
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[TrendingPoolsNetworkRequest](Requests/Onchain/TrendingPoolsNetworkRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PublicTreasuryApi

> Source: [PublicTreasuryApi](Api/PublicTreasuryApi.cs)

<details>
<summary><code>Task&lt;PublicTreasuryEntity&gt; PublicTreasuryEntity(PublicTreasuryEntityRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query public companies' and governments' cryptocurrency holdings by entity ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PublicTreasuryApi.PublicTreasuryEntity(new PublicTreasuryEntityRequest
    {
        EntityId = "some example string",
    });
    // TODO: Handle 'response' of type PublicTreasuryEntity
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PublicTreasuryEntityRequest](Requests/PublicTreasuryApi/PublicTreasuryEntityRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasuryEntity](Models/PublicTreasuryEntity.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublicTreasuryEntityChart&gt; PublicTreasuryEntityChart(PublicTreasuryEntityChartRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query historical cryptocurrency holdings chart of public companies and governments by entity ID and coin ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PublicTreasuryApi.PublicTreasuryEntityChart(new PublicTreasuryEntityChartRequest
    {
        EntityId = "some example string",
        CoinId = "some example string",
        Days = "some example string",
    });
    // TODO: Handle 'response' of type PublicTreasuryEntityChart
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PublicTreasuryEntityChartRequest](Requests/PublicTreasuryApi/PublicTreasuryEntityChartRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasuryEntityChart](Models/PublicTreasuryEntityChart.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublicTreasuryTransactionHistory&gt; PublicTreasuryTransactionHistory(PublicTreasuryTransactionHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query public companies' and governments' cryptocurrency transaction history by entity ID

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PublicTreasuryApi.PublicTreasuryTransactionHistory(
        new PublicTreasuryTransactionHistoryRequest { EntityId = "some example string" });
    // TODO: Handle 'response' of type PublicTreasuryTransactionHistory
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PublicTreasuryTransactionHistoryRequest](Requests/PublicTreasuryApi/PublicTreasuryTransactionHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasuryTransactionHistory](Models/PublicTreasuryTransactionHistory.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## SearchApi

> Source: [SearchApi](Api/SearchApi.cs)

<details>
<summary><code>Task&lt;Search&gt; SearchData(SearchDataRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To search for coins, categories and markets listed on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SearchApi.SearchData(new SearchDataRequest { Query = "some example string" });
    // TODO: Handle 'response' of type Search
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchDataRequest](Requests/SearchApi/SearchDataRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Search](Models/Search.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TrendingSearch&gt; TrendingSearch(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query trending search coins, NFTs and categories on CoinGecko in the last 24 hours

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.SearchApi.TrendingSearch();
    // TODO: Handle 'response' of type TrendingSearch
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TrendingSearch](Models/TrendingSearch.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Simple

> Source: [Simple](Api/Simple.cs)

<details>
<summary><code>Task&lt;IReadOnlyDictionary&lt;string, SimplePrice&gt;&gt; SimplePrice(SimplePriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query the prices of one or more coins by using their unique Coin API IDs, symbols, or names

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Simple.SimplePrice(new SimplePriceRequest { VsCurrencies = "some example string" });
    // TODO: Handle 'response' of type IReadOnlyDictionary<string, SimplePrice>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SimplePriceRequest](Requests/Simple/SimplePriceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyDictionary&lt;string, [SimplePrice](Models/SimplePrice.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;string&gt;&gt; SimpleSupportedCurrencies(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query all the supported currencies on CoinGecko

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Simple.SimpleSupportedCurrencies();
    // TODO: Handle 'response' of type IReadOnlyList<string>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;string&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyDictionary&lt;string, SimplePrice&gt;&gt; SimpleTokenPrice(SimpleTokenPriceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

To query one or more token prices by using their token contract addresses

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Simple.SimpleTokenPrice(new SimpleTokenPriceRequest
    {
        Id = "some example string",
        ContractAddresses = "some example string",
        VsCurrencies = "some example string",
    });
    // TODO: Handle 'response' of type IReadOnlyDictionary<string, SimplePrice>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SimpleTokenPriceRequest](Requests/Simple/SimpleTokenPriceRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyDictionary&lt;string, [SimplePrice](Models/SimplePrice.cs)&gt;</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

