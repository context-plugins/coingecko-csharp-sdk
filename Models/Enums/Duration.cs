using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Duration>))]
public sealed record Duration : OpenStringEnum<Duration>
{
    private Duration(string value) : base(value)
    {
    }

    public static readonly Duration _5M = new("5m");

    public static readonly Duration _1H = new("1h");

    public static readonly Duration _6H = new("6h");

    public static readonly Duration _24H = new("24h");

    public TResult Match<TResult>(Func<TResult> on_5M,
        Func<TResult> on_1H,
        Func<TResult> on_6H,
        Func<TResult> on_24H,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _5M => on_5M(),
            _ when this == _1H => on_1H(),
            _ when this == _6H => on_6H(),
            _ when this == _24H => on_24H(),
            _ => otherwise(Value)
        };

    public void Match(Action on_5M, Action on_1H, Action on_6H, Action on_24H, Action<string> otherwise)
    {
        if (this == _5M) on_5M();
        else if (this == _1H) on_1H();
        else if (this == _6H) on_6H();
        else if (this == _24H) on_24H();
        else otherwise(Value);
    }
}
