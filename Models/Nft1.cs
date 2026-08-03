using System.Text.Json.Serialization;

namespace CoinGeckoDemoApi.Models;

public record Nft1
{
    /// <summary>
    /// NFT collection ID
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// NFT collection name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// NFT collection symbol
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// NFT collection thumb image URL
    /// </summary>
    [JsonPropertyName("thumb")]
    public required string Thumb { get; init; }

    /// <summary>
    /// NFT contract internal ID
    /// </summary>
    [JsonPropertyName("nft_contract_id")]
    public required int NftContractId { get; init; }

    /// <summary>
    /// NFT collection native currency symbol
    /// </summary>
    [JsonPropertyName("native_currency_symbol")]
    public required string NativeCurrencySymbol { get; init; }

    /// <summary>
    /// NFT collection floor price in native currency
    /// </summary>
    [JsonPropertyName("floor_price_in_native_currency")]
    public required double FloorPriceInNativeCurrency { get; init; }

    /// <summary>
    /// NFT collection floor price 24 hours percentage change
    /// </summary>
    [JsonPropertyName("floor_price_24h_percentage_change")]
    public required double FloorPrice24HPercentageChange { get; init; }

    [JsonPropertyName("data")]
    public required Data3 Data { get; init; }
}
