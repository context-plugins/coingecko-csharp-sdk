using System.Collections.Generic;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models;

/// <summary>
/// ICO data
/// </summary>
public record IcoData
{
    /// <summary>
    /// ICO start date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ico_start_date")]
    public string? IcoStartDate { get; init; }

    /// <summary>
    /// ICO end date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ico_end_date")]
    public string? IcoEndDate { get; init; }

    /// <summary>
    /// Short description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_desc")]
    public string? ShortDesc { get; init; }

    /// <summary>
    /// Detailed description
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// ICO related links
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("links")]
    public IReadOnlyDictionary<string, string>? Links { get; init; }

    /// <summary>
    /// Softcap currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softcap_currency")]
    public string? SoftcapCurrency { get; init; }

    /// <summary>
    /// Hardcap currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hardcap_currency")]
    public string? HardcapCurrency { get; init; }

    /// <summary>
    /// Total raised currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_raised_currency")]
    public string? TotalRaisedCurrency { get; init; }

    /// <summary>
    /// Softcap amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("softcap_amount")]
    public double? SoftcapAmount { get; init; }

    /// <summary>
    /// Hardcap amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hardcap_amount")]
    public double? HardcapAmount { get; init; }

    /// <summary>
    /// Total raised amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_raised")]
    public double? TotalRaised { get; init; }

    /// <summary>
    /// Quote pre-sale currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_pre_sale_currency")]
    public string? QuotePreSaleCurrency { get; init; }

    /// <summary>
    /// Base pre-sale amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_pre_sale_amount")]
    public double? BasePreSaleAmount { get; init; }

    /// <summary>
    /// Quote pre-sale amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_pre_sale_amount")]
    public double? QuotePreSaleAmount { get; init; }

    /// <summary>
    /// Quote public sale currency
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_public_sale_currency")]
    public string? QuotePublicSaleCurrency { get; init; }

    /// <summary>
    /// Base public sale amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_public_sale_amount")]
    public double? BasePublicSaleAmount { get; init; }

    /// <summary>
    /// Quote public sale amount
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quote_public_sale_amount")]
    public double? QuotePublicSaleAmount { get; init; }

    /// <summary>
    /// Accepting currencies
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepting_currencies")]
    public string? AcceptingCurrencies { get; init; }

    /// <summary>
    /// Country of origin
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country_origin")]
    public string? CountryOrigin { get; init; }

    /// <summary>
    /// Pre-sale start date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_sale_start_date")]
    public string? PreSaleStartDate { get; init; }

    /// <summary>
    /// Pre-sale end date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_sale_end_date")]
    public string? PreSaleEndDate { get; init; }

    /// <summary>
    /// Whitelist URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whitelist_url")]
    public string? WhitelistUrl { get; init; }

    /// <summary>
    /// Whitelist start date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whitelist_start_date")]
    public string? WhitelistStartDate { get; init; }

    /// <summary>
    /// Whitelist end date
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whitelist_end_date")]
    public string? WhitelistEndDate { get; init; }

    /// <summary>
    /// Bounty detail URL
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bounty_detail_url")]
    public string? BountyDetailUrl { get; init; }

    /// <summary>
    /// Amount for sale
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_for_sale")]
    public double? AmountForSale { get; init; }

    /// <summary>
    /// KYC required
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kyc_required")]
    public bool? KycRequired { get; init; }

    /// <summary>
    /// Whitelist available
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whitelist_available")]
    public bool? WhitelistAvailable { get; init; }

    /// <summary>
    /// Pre-sale available
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_sale_available")]
    public bool? PreSaleAvailable { get; init; }

    /// <summary>
    /// Pre-sale ended
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pre_sale_ended")]
    public bool? PreSaleEnded { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
