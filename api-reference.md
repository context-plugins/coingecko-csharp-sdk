# Reference

> Source: [CoinGeckoDemoApiClient](CoinGeckoDemoApiClient.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;AssetPlatform&gt;&gt; AssetPlatformsList(Filter? filter, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.AssetPlatformsList(filter);
    // TODO: Handle 'response' of type IReadOnlyList<AssetPlatform>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>filter</code> | <code>[Filter?](Models/Enums/Filter.cs)</code> | Apply relevant filters to results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[AssetPlatform](Models/AssetPlatform.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Category1&gt;&gt; CoinsCategories(Order2? order, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsCategories(order);
    // TODO: Handle 'response' of type IReadOnlyList<Category1>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>[Order2?](Models/Enums/Order2.cs)</code> | Sort results by field. <br>Default: `market_cap_desc` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Category1](Models/Category1.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CategoriesList&gt;&gt; CoinsCategoriesList(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsCategoriesList();
    // TODO: Handle 'response' of type IReadOnlyList<CategoriesList>
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsContractAddress&gt; CoinsContractAddress(string id = "ethereum", string contractAddress = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsContractAddress();
    // TODO: Handle 'response' of type CoinsContractAddress
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | Asset platform ID. <br>*refers to [`/asset_platforms`](/reference/asset-platforms-list).<br>**Default**: "ethereum" |
| <code>contractAddress</code> | <code>string</code> | The contract address of token.<br>**Default**: "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsContractAddress](Models/CoinsContractAddress.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsId&gt; CoinsId(bool? localization, bool? tickers, bool? marketData, bool? communityData, bool? developerData, bool? sparkline, bool? includeCategoriesDetails, DexPairFormat? dexPairFormat, string id = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsId(localization,
        tickers,
        marketData,
        communityData,
        developerData,
        sparkline,
        includeCategoriesDetails,
        dexPairFormat);
    // TODO: Handle 'response' of type CoinsId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>localization</code> | <code>bool?</code> | Include all localized languages in the response. <br>Default: true |
| <code>tickers</code> | <code>bool?</code> | Include tickers data. <br>Default: true |
| <code>marketData</code> | <code>bool?</code> | Include market data. <br>Default: true |
| <code>communityData</code> | <code>bool?</code> | Include community data. <br>Default: true |
| <code>developerData</code> | <code>bool?</code> | Include developer data. <br>Default: true |
| <code>sparkline</code> | <code>bool?</code> | Include sparkline 7-day data. <br>Default: false |
| <code>includeCategoriesDetails</code> | <code>bool?</code> | Include categories details. <br>Default: false |
| <code>dexPairFormat</code> | <code>[DexPairFormat?](Models/Enums/DexPairFormat.cs)</code> | Set to `symbol` to display DEX pair base and target as symbols. <br>Default: `contract_address` |
| <code>id</code> | <code>string</code> | Coin ID. <br>*refers to [`/coins/list`](/reference/coins-list)<br>**Default**: "bitcoin" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsId](Models/CoinsId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsIdHistory&gt; CoinsIdHistory(bool? localization, string id = "bitcoin", string date = "30-12-2025", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsIdHistory(localization);
    // TODO: Handle 'response' of type CoinsIdHistory
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>localization</code> | <code>bool?</code> | Include all the localized languages in response. <br>Default: true |
| <code>id</code> | <code>string</code> | Coin ID. <br>*refers to [`/coins/list`](/reference/coins-list).<br>**Default**: "bitcoin" |
| <code>date</code> | <code>string</code> | The date of data snapshot. <br>Format: `dd-mm-yyyy`<br>**Default**: "30-12-2025" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsIdHistory](Models/CoinsIdHistory.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; CoinsIdMarketChart(Interval? interval, Precision? precision, string id = "bitcoin", string vsCurrency = "usd", string days = "1", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsIdMarketChart(interval, precision);
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>interval</code> | <code>[Interval?](Models/Enums/Interval.cs)</code> | Data interval, leave empty for auto granularity. |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal place for currency price value. |
| <code>id</code> | <code>string</code> | Coin ID. <br>*refers to [`/coins/list`](/reference/coins-list).<br>**Default**: "bitcoin" |
| <code>vsCurrency</code> | <code>string</code> | Target currency of market data. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies).<br>**Default**: "usd" |
| <code>days</code> | <code>string</code> | Data up to number of days ago. <br>You may use any integer or `max` for number of days.<br>**Default**: "1" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; CoinsIdMarketChartRange(Precision? precision, string id = "bitcoin", string vsCurrency = "usd", int from = 1767024000, int to = 1777564800, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsIdMarketChartRange(precision);
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal place for currency price value. |
| <code>id</code> | <code>string</code> | Coin ID. <br>*refers to [`/coins/list`](/reference/coins-list).<br>**Default**: "bitcoin" |
| <code>vsCurrency</code> | <code>string</code> | Target currency of market data. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies).<br>**Default**: "usd" |
| <code>from</code> | <code>int</code> | Starting date in UNIX timestamp.<br>**Default**: 1767024000 |
| <code>to</code> | <code>int</code> | Ending date in UNIX timestamp.<br>**Default**: 1777564800 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;double&gt;&gt;&gt; CoinsIdOhlc(Days days, Precision? precision, string id = "bitcoin", string vsCurrency = "usd", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsIdOhlc(days, precision);
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<double>>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>days</code> | <code>[Days](Models/Enums/Days.cs)</code> | Data up to number of days ago. |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal place for currency price value. |
| <code>id</code> | <code>string</code> | Coin ID. <br>*refers to [`/coins/list`](/reference/coins-list).<br>**Default**: "bitcoin" |
| <code>vsCurrency</code> | <code>string</code> | Target currency of price data. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies).<br>**Default**: "usd" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;double&gt;&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsIdTickers&gt; CoinsIdTickers(string? exchangeIds, bool? includeExchangeLogo, int? page, Order1? order, bool? depth, DexPairFormat? dexPairFormat, string id = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsIdTickers(exchangeIds, includeExchangeLogo, page, order, depth, dexPairFormat);
    // TODO: Handle 'response' of type CoinsIdTickers
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>exchangeIds</code> | <code>string?</code> | Exchange ID. <br>*refers to [`/exchanges/list`](/reference/exchanges-list) |
| <code>includeExchangeLogo</code> | <code>bool?</code> | Include exchange logo. <br>Default: false |
| <code>page</code> | <code>int?</code> | Page through results |
| <code>order</code> | <code>[Order1?](Models/Enums/Order1.cs)</code> | Sort the order of responses. <br>Default: trust_score_desc |
| <code>depth</code> | <code>bool?</code> | Include 2% orderbook depth, i.e. `cost_to_move_up_usd` and `cost_to_move_down_usd`. <br>Default: false |
| <code>dexPairFormat</code> | <code>[DexPairFormat?](Models/Enums/DexPairFormat.cs)</code> | Set to `symbol` to display DEX pair base and target as symbols. <br>Default: `contract_address` |
| <code>id</code> | <code>string</code> | Coin ID. <br>*refers to [`/coins/list`](/reference/coins-list)<br>**Default**: "bitcoin" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsIdTickers](Models/CoinsIdTickers.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CoinsList&gt;&gt; CoinsList(bool? includePlatform, Status? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsList(includePlatform, status);
    // TODO: Handle 'response' of type IReadOnlyList<CoinsList>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includePlatform</code> | <code>bool?</code> | Include platform and token's contract addresses. <br>Default: false |
| <code>status</code> | <code>[Status?](Models/Enums/Status.cs)</code> | Filter by status of coins. <br>Default: active |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CoinsList](Models/CoinsList.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CoinsMarket&gt;&gt; CoinsMarkets(IncludeTokens? includeTokens, string? category, Order? order, int? perPage, int? page, bool? sparkline, string? priceChangePercentage, Locale? locale, Precision? precision, bool? includeRehypothecated, string vsCurrency = "usd", string? ids = "bitcoin", string? names = "Bitcoin", string? symbols = "btc", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CoinsMarkets(includeTokens,
        category,
        order,
        perPage,
        page,
        sparkline,
        priceChangePercentage,
        locale,
        precision,
        includeRehypothecated);
    // TODO: Handle 'response' of type IReadOnlyList<CoinsMarket>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeTokens</code> | <code>[IncludeTokens?](Models/Enums/IncludeTokens.cs)</code> | For `symbols` lookups, specify `all` to include all matching tokens. <br>Default `top` returns top-ranked tokens by market cap or volume. |
| <code>category</code> | <code>string?</code> | Filter based on coins' category. <br>*refers to [`/coins/categories/list`](/reference/coins-categories-list) |
| <code>order</code> | <code>[Order?](Models/Enums/Order.cs)</code> | Sort result by field. <br>Default: market_cap_desc |
| <code>perPage</code> | <code>int?</code> | Total results per page. <br>Default: 100 <br>Valid values: 1...250 |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default: 1 |
| <code>sparkline</code> | <code>bool?</code> | Include sparkline 7-day data. <br>Default: false |
| <code>priceChangePercentage</code> | <code>string?</code> | Include price change percentage timeframe, comma-separated if querying more than 1 timeframe. <br>Valid values: `1h`, `24h`, `7d`, `14d`, `30d`, `200d`, `1y` |
| <code>locale</code> | <code>[Locale?](Models/Enums/Locale.cs)</code> | Language background. <br>Default: en |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal places for currency price value |
| <code>includeRehypothecated</code> | <code>bool?</code> | Include rehypothecated tokens in results. When true, returns `market_cap_rank_with_rehypothecated` field. <br>Default: false |
| <code>vsCurrency</code> | <code>string</code> | Target currency of coins and market data. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies)<br>**Default**: "usd" |
| <code>ids</code> | <code>string?</code> | Coins' IDs, comma-separated if querying more than 1 coin. <br>*refers to [`/coins/list`](/reference/coins-list)<br>**Default**: "bitcoin" |
| <code>names</code> | <code>string?</code> | Coins' names, comma-separated if querying more than 1 coin.<br>**Default**: "Bitcoin" |
| <code>symbols</code> | <code>string?</code> | Coins' symbols, comma-separated if querying more than 1 coin.<br>**Default**: "btc" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CoinsMarket](Models/CoinsMarket.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublicTreasury&gt; CompaniesPublicTreasury(Entity entity, int? perPage, int? page, Order5? order, string coinId = "bitcoin", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CompaniesPublicTreasury(entity, perPage, page, order);
    // TODO: Handle 'response' of type PublicTreasury
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>entity</code> | <code>[Entity](Models/Enums/Entity.cs)</code> | Public company or government entity. |
| <code>perPage</code> | <code>int?</code> | Total results per page. <br>Default value: 250 <br>Valid values: 1...250 |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>order</code> | <code>[Order5?](Models/Enums/Order5.cs)</code> | Sort order for results. <br>Default: `total_holdings_usd_desc` |
| <code>coinId</code> | <code>string</code> | Coin ID. <br>e.g. `bitcoin`, `ethereum`, `solana`, `binancecoin`<br>**Default**: "bitcoin" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasury](Models/AnyOf/PublicTreasury.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; ContractAddressMarketChart(Interval? interval, Precision? precision, string id = "ethereum", string contractAddress = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48", string vsCurrency = "usd", string days = "1", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ContractAddressMarketChart(interval, precision);
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>interval</code> | <code>[Interval?](Models/Enums/Interval.cs)</code> | Data interval, leave empty for auto granularity. |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal place for currency price value. |
| <code>id</code> | <code>string</code> | Asset platform ID. <br>*refers to [`/asset_platforms`](/reference/asset-platforms-list).<br>**Default**: "ethereum" |
| <code>contractAddress</code> | <code>string</code> | The contract address of token.<br>**Default**: "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48" |
| <code>vsCurrency</code> | <code>string</code> | Target currency of market data. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies).<br>**Default**: "usd" |
| <code>days</code> | <code>string</code> | Data up to number of days ago. <br>You may use any integer or `max` for number of days.<br>**Default**: "1" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsMarketChart&gt; ContractAddressMarketChartRange(Precision? precision, string id = "ethereum", string contractAddress = "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48", string vsCurrency = "usd", int from = 1767024000, int to = 1777564800, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ContractAddressMarketChartRange(precision);
    // TODO: Handle 'response' of type CoinsMarketChart
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal place for currency price value. |
| <code>id</code> | <code>string</code> | Asset platform ID. <br>*refers to [`/asset_platforms`](/reference/asset-platforms-list).<br>**Default**: "ethereum" |
| <code>contractAddress</code> | <code>string</code> | The contract address of token.<br>**Default**: "0xa0b86991c6218b36c1d19d4a2e9eb0ce3606eb48" |
| <code>vsCurrency</code> | <code>string</code> | Target currency of market data. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies).<br>**Default**: "usd" |
| <code>from</code> | <code>int</code> | Starting date in UNIX timestamp.<br>**Default**: 1767024000 |
| <code>to</code> | <code>int</code> | Ending date in UNIX timestamp.<br>**Default**: 1777564800 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsMarketChart](Models/CoinsMarketChart.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Global&gt; CryptoGlobal(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CryptoGlobal();
    // TODO: Handle 'response' of type Global
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DerivativesExchange&gt;&gt; DerivativesExchanges(Order4? order, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.DerivativesExchanges(order, perPage, page);
    // TODO: Handle 'response' of type IReadOnlyList<DerivativesExchange>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>[Order4?](Models/Enums/Order4.cs)</code> | Sort order of responses. <br>Default: `open_interest_btc_desc` |
| <code>perPage</code> | <code>int?</code> | Total results per page. |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[DerivativesExchange](Models/DerivativesExchange.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DerivativesExchangesId&gt; DerivativesExchangesId(IncludeTickers? includeTickers, string id = "binance_futures", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.DerivativesExchangesId(includeTickers);
    // TODO: Handle 'response' of type DerivativesExchangesId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeTickers</code> | <code>[IncludeTickers?](Models/Enums/IncludeTickers.cs)</code> | Include tickers data. <br>Default: tickers data is not included. |
| <code>id</code> | <code>string</code> | Derivative exchange ID. <br>*refers to [`/derivatives/exchanges/list`](/reference/derivatives-exchanges-list).<br>**Default**: "binance_futures" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DerivativesExchangesId](Models/DerivativesExchangesId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DerivativesExchangesList&gt;&gt; DerivativesExchangesList(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.DerivativesExchangesList();
    // TODO: Handle 'response' of type IReadOnlyList<DerivativesExchangesList>
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;DerivativesTicker&gt;&gt; DerivativesTickers(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.DerivativesTickers();
    // TODO: Handle 'response' of type IReadOnlyList<DerivativesTicker>
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;DexesList&gt; DexesList(int? page, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.DexesList(page);
    // TODO: Handle 'response' of type DexesList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[DexesList](Models/DexesList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;EntitiesList&gt;&gt; EntitiesList(EntityType? entityType, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.EntitiesList(entityType, perPage, page);
    // TODO: Handle 'response' of type IReadOnlyList<EntitiesList>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>entityType</code> | <code>[EntityType?](Models/Enums/EntityType.cs)</code> | Filter by entity type. |
| <code>perPage</code> | <code>int?</code> | Total results per page. <br>Default value: 100 <br>Valid values: 1...250 |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[EntitiesList](Models/EntitiesList.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ExchangeRates&gt; ExchangeRates(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ExchangeRates();
    // TODO: Handle 'response' of type ExchangeRates
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Exchange1&gt;&gt; Exchanges(double? perPage, double? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Exchanges(perPage, page);
    // TODO: Handle 'response' of type IReadOnlyList<Exchange1>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>perPage</code> | <code>double?</code> | Total results per page. <br>Default: 100. <br>Valid values: 1...250 |
| <code>page</code> | <code>double?</code> | Page through results. <br>Default: 1 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Exchange1](Models/Exchange1.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ExchangesId&gt; ExchangesId(DexPairFormat? dexPairFormat, string id = "binance", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ExchangesId(dexPairFormat);
    // TODO: Handle 'response' of type ExchangesId
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>dexPairFormat</code> | <code>[DexPairFormat?](Models/Enums/DexPairFormat.cs)</code> | Set to `symbol` to display DEX pair base and target as symbols. <br>Default: `contract_address` |
| <code>id</code> | <code>string</code> | Exchange ID. <br>*refers to [`/exchanges/list`](/reference/exchanges-list).<br>**Default**: "binance" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ExchangesId](Models/ExchangesId.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CoinsIdTickers&gt; ExchangesIdTickers(string? coinIds, bool? includeExchangeLogo, double? page, bool? depth, Order3? order, DexPairFormat? dexPairFormat, string id = "binance", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ExchangesIdTickers(coinIds, includeExchangeLogo, page, depth, order, dexPairFormat);
    // TODO: Handle 'response' of type CoinsIdTickers
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>coinIds</code> | <code>string?</code> | Filter tickers by coin IDs, comma-separated if querying more than 1 coin. <br>*refers to [`/coins/list`](/reference/coins-list). |
| <code>includeExchangeLogo</code> | <code>bool?</code> | Include exchange logo. <br>Default: false |
| <code>page</code> | <code>double?</code> | Page through results. |
| <code>depth</code> | <code>bool?</code> | Include 2% orderbook depth (cost_to_move_up_usd and cost_to_move_down_usd). <br>Default: false |
| <code>order</code> | <code>[Order3?](Models/Enums/Order3.cs)</code> | Sort the order of responses. <br>Default: `trust_score_desc` |
| <code>dexPairFormat</code> | <code>[DexPairFormat?](Models/Enums/DexPairFormat.cs)</code> | Set to `symbol` to display DEX pair base and target as symbols. <br>Default: `contract_address` |
| <code>id</code> | <code>string</code> | Exchange ID. <br>*refers to [`/exchanges/list`](/reference/exchanges-list).<br>**Default**: "binance" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CoinsIdTickers](Models/CoinsIdTickers.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;IReadOnlyList&lt;ExchangeVolumeChart&gt;&gt;&gt; ExchangesIdVolumeChart(Days days, string id = "binance", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ExchangesIdVolumeChart(days);
    // TODO: Handle 'response' of type IReadOnlyList<IReadOnlyList<ExchangeVolumeChart>>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>days</code> | <code>[Days](Models/Enums/Days.cs)</code> | Data up to number of days ago. |
| <code>id</code> | <code>string</code> | Exchange ID or derivative exchange ID. <br>*refers to [`/exchanges/list`](/reference/exchanges-list) or [`/derivatives/exchanges/list`](/reference/derivatives-exchanges-list).<br>**Default**: "binance" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;IReadOnlyList&lt;[ExchangeVolumeChart](Models/AnyOf/ExchangeVolumeChart.cs)&gt;&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;ExchangesList&gt;&gt; ExchangesList(Status? status, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.ExchangesList(status);
    // TODO: Handle 'response' of type IReadOnlyList<ExchangesList>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>status</code> | <code>[Status?](Models/Enums/Status.cs)</code> | Filter by status of exchanges. <br>Default: `active` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[ExchangesList](Models/ExchangesList.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;GlobalDeFi&gt; GlobalDefi(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.GlobalDefi();
    // TODO: Handle 'response' of type GlobalDeFi
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; LatestPoolsList(string? include, int? page, bool? includeGtCommunityData, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.LatestPoolsList(include, page, includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex`, `network` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; LatestPoolsNetwork(string? include, int? page, bool? includeGtCommunityData, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.LatestPoolsNetwork(include, page, includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NetworksList&gt; NetworksList(int? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.NetworksList(page);
    // TODO: Handle 'response' of type NetworksList
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NetworksList](Models/NetworksList.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NftData&gt; NftsContractAddress(string assetPlatformId = "ethereum", string contractAddress = "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.NftsContractAddress();
    // TODO: Handle 'response' of type NftData
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>assetPlatformId</code> | <code>string</code> | Asset platform ID. <br>*refers to [`/asset_platforms`](/reference/asset-platforms-list).<br>**Default**: "ethereum" |
| <code>contractAddress</code> | <code>string</code> | Contract address of the NFT collection.<br>**Default**: "0xBd3531dA5CF5857e7CfAA92426877b022e612cf8" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NftData](Models/NftData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;NftData&gt; NftsId(string id = "pudgy-penguins", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.NftsId();
    // TODO: Handle 'response' of type NftData
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>id</code> | <code>string</code> | NFT collection ID. <br>*refers to [`/nfts/list`](/reference/nfts-list).<br>**Default**: "pudgy-penguins" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[NftData](Models/NftData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;NfTsList&gt;&gt; NftsList(Order7? order, int? perPage, int? page, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.NftsList(order, perPage, page);
    // TODO: Handle 'response' of type IReadOnlyList<NfTsList>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>order</code> | <code>[Order7?](Models/Enums/Order7.cs)</code> | Sort order of responses. |
| <code>perPage</code> | <code>int?</code> | Total results per page. <br>Valid values: 1...250 |
| <code>page</code> | <code>int?</code> | Page through results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[NfTsList](Models/NfTsList.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;OnchainSimplePrice&gt; OnchainSimplePrice(bool? includeMarketCap, bool? mcapFdvFallback, bool? include24HrVol, bool? include24HrPriceChange, bool? includeTotalReserveInUsd, bool? includeInactiveSource, string network = "eth", string addresses = "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.OnchainSimplePrice(includeMarketCap,
        mcapFdvFallback,
        include24HrVol,
        include24HrPriceChange,
        includeTotalReserveInUsd,
        includeInactiveSource);
    // TODO: Handle 'response' of type OnchainSimplePrice
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeMarketCap</code> | <code>bool?</code> | Include market capitalization. <br>Default: `false` |
| <code>mcapFdvFallback</code> | <code>bool?</code> | Return FDV if market cap is not available. <br>Default: `false` |
| <code>include24HrVol</code> | <code>bool?</code> | Include 24hr volume. <br>Default: `false` |
| <code>include24HrPriceChange</code> | <code>bool?</code> | Include 24hr price change. <br>Default: `false` |
| <code>includeTotalReserveInUsd</code> | <code>bool?</code> | Include total reserve in USD. <br>Default: `false` |
| <code>includeInactiveSource</code> | <code>bool?</code> | Include token price data from inactive pools using the most recent swap. <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>addresses</code> | <code>string</code> | Token contract address, comma-separated if more than one token contract address.<br>**Default**: "0xc02aaa39b223fe8d0a0e5c4f27ead9083c756cc2" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OnchainSimplePrice](Models/OnchainSimplePrice.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PingServer&gt; PingServer(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PingServer();
    // TODO: Handle 'response' of type PingServer
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PoolAddressData&gt; PoolAddress(string? include, bool? includeVolumeBreakdown, bool? includeComposition, string network = "eth", string address = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PoolAddress(include, includeVolumeBreakdown, includeComposition);
    // TODO: Handle 'response' of type PoolAddressData
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>includeVolumeBreakdown</code> | <code>bool?</code> | Include volume breakdown. <br>Default: `false` |
| <code>includeComposition</code> | <code>bool?</code> | Include pool composition. <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>address</code> | <code>string</code> | Pool address.<br>**Default**: "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PoolAddressData](Models/PoolAddressData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Ohlcv&gt; PoolOhlcvContractAddress(Timeframe timeframe, string? aggregate, int? beforeTimestamp, int? limit, Currency? currency, string? token, bool? includeEmptyIntervals, string network = "eth", string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PoolOhlcvContractAddress(timeframe,
        aggregate,
        beforeTimestamp,
        limit,
        currency,
        token,
        includeEmptyIntervals);
    // TODO: Handle 'response' of type Ohlcv
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>timeframe</code> | <code>[Timeframe](Models/Enums/Timeframe.cs)</code> | Timeframe of the OHLCV chart. |
| <code>aggregate</code> | <code>string?</code> | Time period to aggregate each OHLCV. <br>Available values (day): `1` <br>Available values (hour): `1`, `4`, `12` <br>Available values (minute): `1`, `5`, `15` <br>Default value: 1 |
| <code>beforeTimestamp</code> | <code>int?</code> | Return OHLCV data before this timestamp (integer seconds since epoch). |
| <code>limit</code> | <code>int?</code> | Number of OHLCV results to return, maximum 1000. <br>Default value: 100 |
| <code>currency</code> | <code>[Currency?](Models/Enums/Currency.cs)</code> | Return OHLCV in USD or quote token. <br>Default: `usd` |
| <code>token</code> | <code>string?</code> | Return OHLCV for token, use this to invert the chart. <br>Available values: `base`, `quote`, or token address. <br>Default: `base` |
| <code>includeEmptyIntervals</code> | <code>bool?</code> | Include empty intervals with no trade data. <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>poolAddress</code> | <code>string</code> | Pool contract address.<br>**Default**: "0x06da0fd433c1a5d7a4faa01111c044910a184553" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Ohlcv](Models/Ohlcv.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PoolTokensInfo&gt; PoolTokenInfoContractAddress(Include2? include, string network = "solana", string poolAddress = "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PoolTokenInfoContractAddress(include);
    // TODO: Handle 'response' of type PoolTokensInfo
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>[Include2?](Models/Enums/Include2.cs)</code> | Attributes to include. |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "solana" |
| <code>poolAddress</code> | <code>string</code> | Pool contract address.<br>**Default**: "8WwcNqdZjCY5Pt7AkhupAFknV2txca9sq6YBkGzLbvdt" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PoolTokensInfo](Models/PoolTokensInfo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Trades&gt; PoolTradesContractAddress(double? tradeVolumeInUsdGreaterThan, string? token, string network = "eth", string poolAddress = "0x06da0fd433c1a5d7a4faa01111c044910a184553", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PoolTradesContractAddress(tradeVolumeInUsdGreaterThan, token);
    // TODO: Handle 'response' of type Trades
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>tradeVolumeInUsdGreaterThan</code> | <code>double?</code> | Filter trades by trade volume in USD greater than this value. <br>Default value: 0 |
| <code>token</code> | <code>string?</code> | Return trades for token, use this to invert the chart. <br>Available values: `base`, `quote`, or token address. <br>Default: `base` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>poolAddress</code> | <code>string</code> | Pool contract address.<br>**Default**: "0x06da0fd433c1a5d7a4faa01111c044910a184553" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Trades](Models/Trades.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MultiPoolAddressData&gt; PoolsAddresses(string? include, bool? includeVolumeBreakdown, bool? includeComposition, string network = "eth", string addresses = "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PoolsAddresses(include, includeVolumeBreakdown, includeComposition);
    // TODO: Handle 'response' of type MultiPoolAddressData
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>includeVolumeBreakdown</code> | <code>bool?</code> | Include volume breakdown. <br>Default: `false` |
| <code>includeComposition</code> | <code>bool?</code> | Include pool composition. <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>addresses</code> | <code>string</code> | Pool contract address, comma-separated if more than one pool contract address.<br>**Default**: "0x88e6a0c2ddd26feeb64f039a2c41296fcb3f5640" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MultiPoolAddressData](Models/MultiPoolAddressData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublicTreasuryEntity&gt; PublicTreasuryEntity(string? holdingAmountChange, string? holdingChangePercentage, string entityId = "strategy", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PublicTreasuryEntity(holdingAmountChange, holdingChangePercentage);
    // TODO: Handle 'response' of type PublicTreasuryEntity
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>holdingAmountChange</code> | <code>string?</code> | Include holding amount change for specified timeframes, comma-separated if querying more than 1 timeframe. <br>Valid values: `7d`, `14d`, `30d`, `90d`, `1y`, `ytd` |
| <code>holdingChangePercentage</code> | <code>string?</code> | Include holding change percentage for specified timeframes, comma-separated if querying more than 1 timeframe. <br>Valid values: `7d`, `14d`, `30d`, `90d`, `1y`, `ytd` |
| <code>entityId</code> | <code>string</code> | Public company or government entity ID. <br>*refers to [`/entities/list`](/reference/entities-list).<br>**Default**: "strategy" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasuryEntity](Models/PublicTreasuryEntity.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublicTreasuryEntityChart&gt; PublicTreasuryEntityChart(bool? includeEmptyIntervals, string entityId = "strategy", string coinId = "bitcoin", string days = "365", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PublicTreasuryEntityChart(includeEmptyIntervals);
    // TODO: Handle 'response' of type PublicTreasuryEntityChart
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeEmptyIntervals</code> | <code>bool?</code> | Include empty intervals with no transaction data. <br>Default: `false` |
| <code>entityId</code> | <code>string</code> | Public company or government entity ID. <br>*refers to [`/entities/list`](/reference/entities-list).<br>**Default**: "strategy" |
| <code>coinId</code> | <code>string</code> | Coin ID. <br>e.g. `bitcoin`, `ethereum`, `solana`, `binancecoin`<br>**Default**: "bitcoin" |
| <code>days</code> | <code>string</code> | Data up to number of days ago. <br>Valid values: `7`, `14`, `30`, `90`, `180`, `365`<br>**Default**: "365" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasuryEntityChart](Models/PublicTreasuryEntityChart.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PublicTreasuryTransactionHistory&gt; PublicTreasuryTransactionHistory(int? perPage, int? page, Order6? order, string? coinIds, string entityId = "strategy", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PublicTreasuryTransactionHistory(perPage, page, order, coinIds);
    // TODO: Handle 'response' of type PublicTreasuryTransactionHistory
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>perPage</code> | <code>int?</code> | Total results per page. <br>Default value: 100 <br>Valid values: 1...250 |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>order</code> | <code>[Order6?](Models/Enums/Order6.cs)</code> | Sort order of transactions. <br>Default: `date_desc` |
| <code>coinIds</code> | <code>string?</code> | Filter transactions by coin IDs, comma-separated if querying more than 1 coin. <br>*refers to [`/coins/list`](/reference/coins-list). |
| <code>entityId</code> | <code>string</code> | Public company or government entity ID. <br>*refers to [`/entities/list`](/reference/entities-list).<br>**Default**: "strategy" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PublicTreasuryTransactionHistory](Models/PublicTreasuryTransactionHistory.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Search&gt; SearchData(string query, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.SearchData(query);
    // TODO: Handle 'response' of type Search
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>query</code> | <code>string</code> | Search query |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Search](Models/Search.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PoolSearch&gt; SearchPools(string? network, string? include, int? page, string? query = "weth", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.SearchPools(network, include, page);
    // TODO: Handle 'response' of type PoolSearch
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>network</code> | <code>string?</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list). |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>query</code> | <code>string?</code> | Search query: pool contract address, token name, token symbol, or token contract address.<br>**Default**: "weth" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PoolSearch](Models/PoolSearch.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyDictionary&lt;string, SimplePrice&gt;&gt; SimplePrice(IncludeTokens? includeTokens, bool? includeMarketCap, bool? include24HrVol, bool? include24HrChange, bool? includeLastUpdatedAt, Precision? precision, string vsCurrencies = "usd", string? ids = "bitcoin", string? names = "Bitcoin", string? symbols = "btc", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.SimplePrice(includeTokens,
        includeMarketCap,
        include24HrVol,
        include24HrChange,
        includeLastUpdatedAt,
        precision);
    // TODO: Handle 'response' of type IReadOnlyDictionary<string, SimplePrice>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeTokens</code> | <code>[IncludeTokens?](Models/Enums/IncludeTokens.cs)</code> | For `symbols` lookups, specify `all` to include all matching tokens. <br>Default `top` returns top-ranked tokens by market cap or volume. |
| <code>includeMarketCap</code> | <code>bool?</code> | Include market capitalization. <br>Default: false |
| <code>include24HrVol</code> | <code>bool?</code> | Include 24-hour trading volume. <br>Default: false |
| <code>include24HrChange</code> | <code>bool?</code> | Include 24-hour change percentage. <br>Default: false |
| <code>includeLastUpdatedAt</code> | <code>bool?</code> | Include last updated price time as a UNIX timestamp. <br>Default: false |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal places for currency price value |
| <code>vsCurrencies</code> | <code>string</code> | Target currency of coins, comma-separated if querying more than 1 currency. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies)<br>**Default**: "usd" |
| <code>ids</code> | <code>string?</code> | Coins' IDs, comma-separated if querying more than 1 coin. <br>*refers to [`/coins/list`](/reference/coins-list)<br>**Default**: "bitcoin" |
| <code>names</code> | <code>string?</code> | Coins' names, comma-separated if querying more than 1 coin.<br>**Default**: "Bitcoin" |
| <code>symbols</code> | <code>string?</code> | Coins' symbols, comma-separated if querying more than 1 coin.<br>**Default**: "btc" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyDictionary&lt;string, [SimplePrice](Models/SimplePrice.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;string&gt;&gt; SimpleSupportedCurrencies(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.SimpleSupportedCurrencies();
    // TODO: Handle 'response' of type IReadOnlyList<string>
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyDictionary&lt;string, SimplePrice&gt;&gt; SimpleTokenPrice(bool? includeMarketCap, bool? include24HrVol, bool? include24HrChange, bool? includeLastUpdatedAt, Precision? precision, string id = "ethereum", string contractAddresses = "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599", string vsCurrencies = "usd", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.SimpleTokenPrice(includeMarketCap,
        include24HrVol,
        include24HrChange,
        includeLastUpdatedAt,
        precision);
    // TODO: Handle 'response' of type IReadOnlyDictionary<string, SimplePrice>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>includeMarketCap</code> | <code>bool?</code> | Include market capitalization. <br>Default: false |
| <code>include24HrVol</code> | <code>bool?</code> | Include 24-hour trading volume. <br>Default: false |
| <code>include24HrChange</code> | <code>bool?</code> | Include 24-hour change percentage. <br>Default: false |
| <code>includeLastUpdatedAt</code> | <code>bool?</code> | Include last updated price time as a UNIX timestamp. <br>Default: false |
| <code>precision</code> | <code>[Precision?](Models/Enums/Precision.cs)</code> | Decimal places for currency price value |
| <code>id</code> | <code>string</code> | Asset platform's ID. <br>*refers to [`/asset_platforms`](/reference/asset-platforms-list)<br>**Default**: "ethereum" |
| <code>contractAddresses</code> | <code>string</code> | Token contract addresses, comma-separated if querying more than 1 token<br>**Default**: "0x2260fac5e5542a773aa44fbcfedf7c193bc2c599" |
| <code>vsCurrencies</code> | <code>string</code> | Target currency of coins, comma-separated if querying more than 1 currency. <br>*refers to [`/simple/supported_vs_currencies`](/reference/simple-supported-currencies)<br>**Default**: "usd" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyDictionary&lt;string, [SimplePrice](Models/SimplePrice.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenData&gt; TokenDataContractAddress(Include? include, bool? includeComposition, bool? includeInactiveSource, string network = "eth", string address = "0xdac17f958d2ee523a2206206994597c13d831ec7", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TokenDataContractAddress(include, includeComposition, includeInactiveSource);
    // TODO: Handle 'response' of type TokenData
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>[Include?](Models/Enums/Include.cs)</code> | Attributes to include. |
| <code>includeComposition</code> | <code>bool?</code> | Include pool composition. <br>Default: `false` |
| <code>includeInactiveSource</code> | <code>bool?</code> | Include token data from inactive pools using the most recent swap. <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>address</code> | <code>string</code> | Token contract address.<br>**Default**: "0xdac17f958d2ee523a2206206994597c13d831ec7" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenData](Models/TokenData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenInfo&gt; TokenInfoContractAddress(string network = "solana", string address = "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TokenInfoContractAddress();
    // TODO: Handle 'response' of type TokenInfo
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "solana" |
| <code>address</code> | <code>string</code> | Token contract address.<br>**Default**: "Dfh5DzRgSvvCFDoYc2ciTkMrbDfRKybA4SoFbPmApump" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenInfo](Models/TokenInfo.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenLists&gt; TokenLists(string assetPlatformId = "ethereum", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TokenLists();
    // TODO: Handle 'response' of type TokenLists
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>assetPlatformId</code> | <code>string</code> | Asset platform ID. <br>*refers to [`/asset_platforms`](/reference/asset-platforms-list).<br>**Default**: "ethereum" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenLists](Models/TokenLists.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;MultiTokenData&gt; TokensDataContractAddresses(Include? include, bool? includeComposition, bool? includeInactiveSource, string network = "solana", string addresses = "6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TokensDataContractAddresses(include, includeComposition, includeInactiveSource);
    // TODO: Handle 'response' of type MultiTokenData
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>[Include?](Models/Enums/Include.cs)</code> | Attributes to include. |
| <code>includeComposition</code> | <code>bool?</code> | Include pool composition. <br>Default: `false` |
| <code>includeInactiveSource</code> | <code>bool?</code> | Include tokens from inactive pools using the most recent swap. <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "solana" |
| <code>addresses</code> | <code>string</code> | Token contract address, comma-separated if more than one token contract address.<br>**Default**: "6p6xgHyF7AeE6TZkSmFsko444wqoP15icUSqi2jfGiPN,2g4LS3y2myPe6vj9wTvoBE1wKqxvhnZPoZA9QU9upump" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[MultiTokenData](Models/MultiTokenData.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TokenInfoRecentlyUpdated&gt; TokensInfoRecentUpdated(Include3? include, string? network, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TokensInfoRecentUpdated(include, network);
    // TODO: Handle 'response' of type TokenInfoRecentlyUpdated
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>[Include3?](Models/Enums/Include3.cs)</code> | Attributes for related resources to include. |
| <code>network</code> | <code>string?</code> | Filter tokens by provided network. <br>*refers to [`/onchain/networks`](/reference/networks-list). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TokenInfoRecentlyUpdated](Models/TokenInfoRecentlyUpdated.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TopPoolsContractAddress(string? include, bool? includeInactiveSource, int? page, Sort2? sort, bool? includeGtCommunityData, string network = "eth", string tokenAddress = "0xdac17f958d2ee523a2206206994597c13d831ec7", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TopPoolsContractAddress(include,
        includeInactiveSource,
        page,
        sort,
        includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>includeInactiveSource</code> | <code>bool?</code> | Include tokens from inactive pools using the most recent swap. <br>Default: `false` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>sort</code> | <code>[Sort2?](Models/Enums/Sort2.cs)</code> | Sort the pools by field. <br>Default: `h24_volume_usd_liquidity_desc` |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>tokenAddress</code> | <code>string</code> | Token contract address.<br>**Default**: "0xdac17f958d2ee523a2206206994597c13d831ec7" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TopPoolsDex(string? include, int? page, Sort? sort, bool? includeGtCommunityData, string network = "eth", string dex = "sushiswap", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TopPoolsDex(include, page, sort, includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>sort</code> | <code>[Sort?](Models/Enums/Sort.cs)</code> | Sort the pools by field. <br>Default: `h24_tx_count_desc` |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |
| <code>dex</code> | <code>string</code> | DEX ID. <br>*refers to [`/onchain/networks/{network}/dexes`](/reference/dexes-list).<br>**Default**: "sushiswap" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TopPoolsNetwork(string? include, int? page, Sort? sort, bool? includeGtCommunityData, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TopPoolsNetwork(include, page, sort, includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>sort</code> | <code>[Sort?](Models/Enums/Sort.cs)</code> | Sort the pools by field. <br>Default: `h24_tx_count_desc` |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TrendingPoolsList(string? include, int? page, Duration? duration, bool? includeGtCommunityData, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TrendingPoolsList(include, page, duration, includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex`, `network` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>duration</code> | <code>[Duration?](Models/Enums/Duration.cs)</code> | Duration to sort trending list by. <br>Default: `24h` |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Pool&gt; TrendingPoolsNetwork(string? include, int? page, Duration? duration, bool? includeGtCommunityData, string network = "eth", RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TrendingPoolsNetwork(include, page, duration, includeGtCommunityData);
    // TODO: Handle 'response' of type Pool
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>include</code> | <code>string?</code> | Attributes to include, comma-separated if more than one. <br>Available values: `base_token`, `quote_token`, `dex` |
| <code>page</code> | <code>int?</code> | Page through results. <br>Default value: 1 |
| <code>duration</code> | <code>[Duration?](Models/Enums/Duration.cs)</code> | Duration to sort trending list by. <br>Default: `24h` |
| <code>includeGtCommunityData</code> | <code>bool?</code> | Include GeckoTerminal community data (sentiment votes, suspicious reports). <br>Default: `false` |
| <code>network</code> | <code>string</code> | Network ID. <br>*refers to [`/onchain/networks`](/reference/networks-list).<br>**Default**: "eth" |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Pool](Models/Pool.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TrendingSearch&gt; TrendingSearch(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.TrendingSearch();
    // TODO: Handle 'response' of type TrendingSearch
}
catch (SdkException<RawError> ex)
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

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

