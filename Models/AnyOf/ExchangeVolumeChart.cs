using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Extensions;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models.AnyOf;

[JsonConverter(typeof(ExchangeVolumeChartConverter))]
public record ExchangeVolumeChart
{
    private readonly Optional<double> _doubleValue;

    private readonly Optional<string> _stringValue;

    private ExchangeVolumeChart(Optional<double> doubleValue, Optional<string> stringValue)
    {
        _doubleValue = doubleValue;
        _stringValue = stringValue;
    }

    public static ExchangeVolumeChart Double(double value) => new(Optional<double>.Some(value), default);

    public static ExchangeVolumeChart String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetDouble(out double value) => _doubleValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator ExchangeVolumeChart(double value) => Double(value);

    public static implicit operator ExchangeVolumeChart(string value) => String(value);
}

file sealed class ExchangeVolumeChartConverter : JsonConverter<ExchangeVolumeChart>
{
    public override ExchangeVolumeChart Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<double>(root, options, out var doubleValue))
        {
            return ExchangeVolumeChart.Double(doubleValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return ExchangeVolumeChart.String(value);
        }
        throw new JsonException($"JSON does not match double or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, ExchangeVolumeChart value, JsonSerializerOptions options)
    {
        if (value.TryGetDouble(out var doubleValue))
        {
            JsonSerializer.Serialize(writer, doubleValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(ExchangeVolumeChart)} contains no valid value to serialize.");
        }
    }
}
