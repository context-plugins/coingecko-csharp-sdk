using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Days>))]
public sealed record Days : OpenStringEnum<Days>
{
    private Days(string value) : base(value)
    {
    }

    public static readonly Days _1 = new("1");

    public static readonly Days _7 = new("7");

    public static readonly Days _14 = new("14");

    public static readonly Days _30 = new("30");

    public static readonly Days _90 = new("90");

    public static readonly Days _180 = new("180");

    public static readonly Days _365 = new("365");

    public TResult Match<TResult>(Func<TResult> on_1,
        Func<TResult> on_7,
        Func<TResult> on_14,
        Func<TResult> on_30,
        Func<TResult> on_90,
        Func<TResult> on_180,
        Func<TResult> on_365,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _1 => on_1(),
            _ when this == _7 => on_7(),
            _ when this == _14 => on_14(),
            _ when this == _30 => on_30(),
            _ when this == _90 => on_90(),
            _ when this == _180 => on_180(),
            _ when this == _365 => on_365(),
            _ => otherwise(Value)
        };

    public void Match(Action on_1,
        Action on_7,
        Action on_14,
        Action on_30,
        Action on_90,
        Action on_180,
        Action on_365,
        Action<string> otherwise)
    {
        if (this == _1) on_1();
        else if (this == _7) on_7();
        else if (this == _14) on_14();
        else if (this == _30) on_30();
        else if (this == _90) on_90();
        else if (this == _180) on_180();
        else if (this == _365) on_365();
        else otherwise(Value);
    }
}
