using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Include2>))]
public sealed record Include2 : OpenStringEnum<Include2>
{
    private Include2(string value) : base(value)
    {
    }

    public static readonly Include2 Pool = new("pool");

    public TResult Match<TResult>(Func<TResult> onPool, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pool => onPool(),
            _ => otherwise(Value)
        };

    public void Match(Action onPool, Action<string> otherwise)
    {
        if (this == Pool) onPool();
        else otherwise(Value);
    }
}
