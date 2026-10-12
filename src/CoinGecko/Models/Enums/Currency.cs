using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Currency>))]
public sealed record Currency : OpenStringEnum<Currency>
{
    private Currency(string value) : base(value)
    {
    }

    public static readonly Currency Usd = new("usd");

    public static readonly Currency Token = new("token");

    public TResult Match<TResult>(Func<TResult> onUsd, Func<TResult> onToken, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Usd => onUsd(),
            _ when this == Token => onToken(),
            _ => otherwise(Value)
        };

    public void Match(Action onUsd, Action onToken, Action<string> otherwise)
    {
        if (this == Usd) onUsd();
        else if (this == Token) onToken();
        else otherwise(Value);
    }
}
