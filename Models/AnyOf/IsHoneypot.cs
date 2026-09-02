using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Extensions;
using CoinGeckoDemoApi.Core.Models;

namespace CoinGeckoDemoApi.Models.AnyOf;

/// <summary>
/// Whether the token is a honeypot (boolean or 'unknown')
/// </summary>
[JsonConverter(typeof(IsHoneypotConverter))]
public record IsHoneypot
{
    private readonly Optional<bool> _boolValue;

    private readonly Optional<string> _stringValue;

    private IsHoneypot(Optional<bool> boolValue, Optional<string> stringValue)
    {
        _boolValue = boolValue;
        _stringValue = stringValue;
    }

    public static IsHoneypot Bool(bool value) => new(Optional<bool>.Some(value), default);

    public static IsHoneypot String(string value) => new(default, Optional<string>.Some(value));

    public bool TryGetBool(out bool value) => _boolValue.TryGetValue(out value);

    public bool TryGetString(out string value) => _stringValue.TryGetValue(out value);

    public static implicit operator IsHoneypot(bool value) => Bool(value);

    public static implicit operator IsHoneypot(string value) => String(value);
}

file sealed class IsHoneypotConverter : JsonConverter<IsHoneypot>
{
    public override IsHoneypot Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<bool>(root, options, out var boolValue))
        {
            return IsHoneypot.Bool(boolValue);
        }
        if (root.ValueKind == JsonValueKind.String)
        {
            var value = root.GetString()!;
            return IsHoneypot.String(value);
        }
        throw new JsonException($"JSON does not match bool or string schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, IsHoneypot value, JsonSerializerOptions options)
    {
        if (value.TryGetBool(out var boolValue))
        {
            JsonSerializer.Serialize(writer, boolValue, options);
        }
        else if (value.TryGetString(out var stringValue))
        {
            JsonSerializer.Serialize(writer, stringValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(IsHoneypot)} contains no valid value to serialize.");
        }
    }
}
