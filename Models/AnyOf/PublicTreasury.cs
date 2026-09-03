using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Extensions;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models.AnyOf;

[JsonConverter(typeof(PublicTreasuryConverter))]
public record PublicTreasury
{
    private readonly Optional<CompanyTreasury> _companyTreasuryValue;

    private readonly Optional<GovernmentTreasury> _governmentTreasuryValue;

    private PublicTreasury(Optional<CompanyTreasury> companyTreasuryValue,
        Optional<GovernmentTreasury> governmentTreasuryValue)
    {
        _companyTreasuryValue = companyTreasuryValue;
        _governmentTreasuryValue = governmentTreasuryValue;
    }

    public static PublicTreasury CompanyTreasury(CompanyTreasury value) =>
        new(Optional<CompanyTreasury>.Some(value), default);

    public static PublicTreasury GovernmentTreasury(GovernmentTreasury value) =>
        new(default, Optional<GovernmentTreasury>.Some(value));

    public bool TryGetCompanyTreasury(out CompanyTreasury value) =>
        _companyTreasuryValue.TryGetValue(out value);

    public bool TryGetGovernmentTreasury(out GovernmentTreasury value) =>
        _governmentTreasuryValue.TryGetValue(out value);

    public static implicit operator PublicTreasury(CompanyTreasury value) => CompanyTreasury(value);

    public static implicit operator PublicTreasury(GovernmentTreasury value) => GovernmentTreasury(value);
}

file sealed class PublicTreasuryConverter : JsonConverter<PublicTreasury>
{
    public override PublicTreasury Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<CompanyTreasury>(root, options, out var companyTreasuryValue))
        {
            return PublicTreasury.CompanyTreasury(companyTreasuryValue);
        }
        if (JsonSerializer.TryDeserialize<GovernmentTreasury>(root, options, out var governmentTreasuryValue))
        {
            return PublicTreasury.GovernmentTreasury(governmentTreasuryValue);
        }
        throw new JsonException($"JSON does not match CompanyTreasury or GovernmentTreasury schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, PublicTreasury value, JsonSerializerOptions options)
    {
        if (value.TryGetCompanyTreasury(out var companyTreasuryValue))
        {
            JsonSerializer.Serialize(writer, companyTreasuryValue, options);
        }
        else if (value.TryGetGovernmentTreasury(out var governmentTreasuryValue))
        {
            JsonSerializer.Serialize(writer, governmentTreasuryValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(PublicTreasury)} contains no valid value to serialize.");
        }
    }
}
